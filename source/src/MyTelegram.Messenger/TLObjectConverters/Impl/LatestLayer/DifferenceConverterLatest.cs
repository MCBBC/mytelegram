﻿using MyTelegram.Schema.Updates;

namespace MyTelegram.Messenger.TLObjectConverters.Impl.LatestLayer;

public class DifferenceConverterLatest(
    IObjectMapper objectMapper,
    IOptions<MyTelegramMessengerServerOptions> options,
    ILayeredService<IMessageConverter> layeredMessageService,
    ILayeredService<IChatConverter> layeredChatService,
    ILayeredService<IUserConverter> layeredUserService)
    : LayeredConverterBase, IDifferenceConverterLatest
{
    private IChatConverter? _chatConverter;
    private IMessageConverter? _messageConverter;
    private IUserConverter? _userConverter;

    public override int Layer => Layers.LayerLatest;

    public IChannelDifference ToChannelDifference(GetMessageOutput output,
        bool isChannelMember,
        IList<IUpdate> updatesList,
        int updatesMaxPts = 0,
        bool resetLeftToFalse = false)
    {
        var timeout = options.Value.ChannelGetDifferenceIntervalSeconds;
        if (output.MessageList.Count == 0 && updatesList.Count == 0)
        {
            return new TChannelDifferenceEmpty { Final = true, Pts = output.Pts, Timeout = timeout };
        }

        var maxPts = updatesMaxPts;
        if (output.MessageList.Count > 0)
        {
            var boxMaxPts = output.MessageList.Max(p => p.Pts);
            maxPts = Math.Max(updatesMaxPts, boxMaxPts);
        }

        var messageList = GetMessageConverter()
            .ToMessages(output.MessageList, output.PollList, output.ChosenPollOptions, output.SelfUserId);
        var chatList = GetChatConverter().ToChatList(output.SelfUserId, output.ChatList, output.PhotoList).ToList();
        var channelList = GetChatConverter().ToChannelList(
            output.SelfUserId,
            output.ChannelList,
            output.PhotoList,
            output.JoinedChannelIdList,
            output.ChannelMemberList,
            resetLeftToFalse
        );
        var userList = GetUserConverter().ToUserList(output.SelfUserId, output.UserList, output.PhotoList,
            output.ContactList, output.PrivacyList);
        chatList.AddRange(channelList);
        return new TChannelDifference
        {
            Final = output.Pts == maxPts,
            Pts = maxPts,
            Users = new TVector<IUser>(userList),
            OtherUpdates = new TVector<IUpdate>(updatesList),
            Timeout = timeout,
            Chats = new TVector<IChat>(chatList),
            NewMessages = new TVector<IMessage>(messageList)
        };
    }

    public IDifference ToDifference(GetMessageOutput output,
        IPtsReadModel? pts,
        int cachedPts,
        int limit,
        IList<IUpdate> updateList,
        IList<IChat> chatListFromUpdates,
        IReadOnlyCollection<IEncryptedMessageReadModel>? encryptedMessageReadModels)
    {
        var messageList = GetMessageConverter()
            .ToMessages(output.MessageList, output.PollList, output.ChosenPollOptions, output.SelfUserId);
        var userList = GetUserConverter().ToUserList(output.SelfUserId, output.UserList, output.PhotoList,
            output.ContactList, output.PrivacyList);
        var chatList = GetChatConverter().ToChatList(output.SelfUserId, output.ChatList, output.PhotoList).ToList();
        chatList.AddRange(chatListFromUpdates);
        var channelList = GetChatConverter().ToChannelList(
            output.SelfUserId,
            output.ChannelList,
            output.PhotoList,
            output.JoinedChannelIdList,
            output.ChannelMemberList,
            true);
        chatList.AddRange(channelList);

        var qts = pts?.Qts ?? 0;
        var unreadCount = pts?.UnreadCount ?? 0;
        if (unreadCount < 0)
        {
            unreadCount = 0;
        }

        if (updateList.Count == limit)
        {
            var differenceSlice = new TDifferenceSlice
            {
                Chats = new TVector<IChat>(chatList),
                NewEncryptedMessages = new TVector<IEncryptedMessage>(),
                NewMessages = new TVector<IMessage>(messageList),
                OtherUpdates = new TVector<IUpdate>(updateList),
                Users = new TVector<IUser>(userList),
                IntermediateState = pts == null
                    ? new TState
                    {
                        Date = DateTime.UtcNow.ToTimestamp(),
                        Qts = qts,
                        Pts = pts?.Pts ?? 1,
                        UnreadCount = unreadCount,
                        Seq = 1
                    }
                    : objectMapper.Map<IPtsReadModel, TState>(pts)
            };

            return differenceSlice;
        }

        var newEncryptedMessages = Array.Empty<IEncryptedMessage>();

        if (encryptedMessageReadModels?.Count > 0)
        {
            newEncryptedMessages = encryptedMessageReadModels
                .Select(p => objectMapper.Map<IEncryptedMessageReadModel, IEncryptedMessage>(p)).ToArray();
        }

        var difference = new TDifference
        {
            Chats = new TVector<IChat>(chatList),
            NewEncryptedMessages = new TVector<IEncryptedMessage>(newEncryptedMessages),
            NewMessages = new TVector<IMessage>(messageList),
            OtherUpdates = new TVector<IUpdate>(updateList),
            Users = new TVector<IUser>(userList),
            State = pts == null
                ? new TState
                {
                    Date = DateTime.UtcNow.ToTimestamp(),
                    Qts = qts,
                    Pts = pts?.Pts ?? 1,
                    UnreadCount = unreadCount,
                    Seq = 1
                }
                : objectMapper.Map<IPtsReadModel, TState>(pts)
        };
        if (cachedPts > pts?.Pts)
        {
            difference.State.Pts = cachedPts;
        }

        return difference;
    }

    protected IChatConverter GetChatConverter()
    {
        return _chatConverter ??= layeredChatService.GetConverter(GetLayer());
    }

    protected IMessageConverter GetMessageConverter()
    {
        return _messageConverter ??= layeredMessageService.GetConverter(GetLayer());
    }

    protected IUserConverter GetUserConverter()
    {
        var converter = _userConverter ??= layeredUserService.GetConverter(GetLayer());
        // Console.WriteLine($"UserConverter:GetLayer()={GetLayer()} {converter.Layer} {converter.GetType().Namespace}.{converter.GetType().Name}");
        return converter;
    }

    //private readonly IObjectMapper _objectMapper;
    //private readonly IOptions<MyTelegramMessengerServerOptions> _options;

    //public DifferenceConverter(
    //    IObjectMapper objectMapper,
    //    IOptions<MyTelegramMessengerServerOptions> options)
    //{
    //    _objectMapper = objectMapper;
    //    _options = options;
    //}

    //public virtual int Layer => Layers.LayerLatest;

    //public IChannelDifference ToChannelDifference(
    //    IList<IMessage> messages,
    //    IEnumerable<IChat> chatsOrChannels,
    //    IEnumerable<IUser> users,
    //    IList<IUpdate> updates,
    //    int pts,
    //    bool final
    //    )
    //{
    //    var timeout = _options.Value.ChannelGetDifferenceIntervalSeconds;
    //    if (messages.Count == 0 && updates.Count == 0)
    //    {
    //        return new TChannelDifferenceEmpty { Final = true, Pts = pts, Timeout = timeout };
    //    }

    //    return new TChannelDifference
    //    {
    //        Final = final,
    //        Pts = pts,
    //        Users = new TVector<IUser>(users),
    //        OtherUpdates = new TVector<IUpdate>(updates),
    //        Timeout = timeout,
    //        Chats = new TVector<IChat>(chatsOrChannels),
    //        NewMessages = new TVector<IMessage>(messages)
    //    };
    //}

    //public IDifference ToDifference(
    //    IEnumerable<IMessage> messages,
    //    IEnumerable<IChat> chatsOrChannels,
    //    IEnumerable<IUser> users,
    //    IList<IUpdate> updates,
    //    IPtsReadModel? pts,
    //    int cachedPts,
    //    int limit)
    //{
    //    if (updates.Count == limit)
    //    {
    //        var differenceSlice = new TDifferenceSlice
    //        {
    //            Chats = new TVector<IChat>(chatsOrChannels),
    //            NewEncryptedMessages = new TVector<IEncryptedMessage>(),
    //            NewMessages = new TVector<IMessage>(messages),
    //            OtherUpdates = new TVector<IUpdate>(updates),
    //            Users = new TVector<IUser>(users),
    //            IntermediateState = pts == null
    //                ? new TState
    //                {
    //                    Date = DateTime.UtcNow.ToTimestamp()
    //                }
    //                : _objectMapper.Map<IPtsReadModel, TState>(pts)
    //        };

    //        return differenceSlice;
    //    }

    //    var difference = new TDifference
    //    {
    //        Chats = new TVector<IChat>(chatsOrChannels),
    //        NewEncryptedMessages = new TVector<IEncryptedMessage>(),
    //        NewMessages = new TVector<IMessage>(messages),
    //        OtherUpdates = new TVector<IUpdate>(updates),
    //        Users = new TVector<IUser>(users),
    //        State = pts == null
    //            ? new TState
    //            {
    //                Date = DateTime.UtcNow.ToTimestamp()
    //            }
    //            : _objectMapper.Map<IPtsReadModel, TState>(pts)
    //    };
    //    if (cachedPts > pts?.Pts)
    //    {
    //        difference.State.Pts = cachedPts;
    //    }

    //    return difference;
    //}
}