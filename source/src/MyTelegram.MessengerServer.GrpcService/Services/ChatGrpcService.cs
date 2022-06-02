﻿using EventFlow.Queries;
using Google.Protobuf;
using Grpc.Core;
using MyTelegram.GrpcService;
using MyTelegram.MessengerServer.DomainEventHandlers.Converters;
using MyTelegram.MessengerServer.Services.Interfaces;
using MyTelegram.Queries;
using MyTelegram.Schema;

namespace MyTelegram.MessengerServer.GrpcService.Services;

public class ChatGrpcService : ChatService.ChatServiceBase
{
    private readonly IQueryProcessor _queryProcessor;
    //private readonly IObjectMapper<ChannelReadModel,TChannel>
    private readonly IRpcResultProcessor _rpcResultProcessor;
    private readonly ITlChatConverter _chatConverter;
    public ChatGrpcService(IQueryProcessor queryProcessor,
        IRpcResultProcessor rpcResultProcessor,
        ITlChatConverter chatConverter)
    {
        _queryProcessor = queryProcessor;
        _rpcResultProcessor = rpcResultProcessor;
        _chatConverter = chatConverter;
    }

    public override async Task<GetChannelResponse> GetChannel(GetChannelRequest request,
        ServerCallContext context)
    {
        var channelReadModel = await _queryProcessor
            .ProcessAsync(new GetChannelByIdQuery(request.ChannelId), default)
            .ConfigureAwait(false);
        var channelMemberReadModel = await _queryProcessor
            .ProcessAsync(new GetChannelMemberByUidQuery(request.ChannelId, request.SelfUserId), default)
            .ConfigureAwait(false);
        // Console.WriteLine($"### Get channel info,userId={request.SelfUserId} channelId={request.ChannelId}");
        return new GetChannelResponse
        {
            ChannelData = ByteString.CopyFrom(_chatConverter
                .ToChannel(channelReadModel, channelMemberReadModel, request.SelfUserId, channelMemberReadModel == null).ToBytes())
        };
    }
}