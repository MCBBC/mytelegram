// <auto-generated/>
// ReSharper disable All
using System.Text.Json.Serialization;

namespace MyTelegram.Messenger.NativeAot;

// Generation time:2023-12-13 09:55:24Z
// MyTelegram.Domain
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Channel.ChannelSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Chat.ChatSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Dialog.DialogFilterDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Dialog.DialogFilterUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Dialog.DialogSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Messaging.MessageSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.PeerNotifySettings.PeerNotifySettingsSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.PeerSettings.PeerSettingsBarHiddenEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.PeerSettings.PeerSettingsCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.PeerSettings.PeerSettingsSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Photo.EmptyPhotoEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Poll.VoteAnswerCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Poll.VoteAnswerDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Poll.VoteSucceededEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Pts.PtsSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Pts.TempPtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.Updates.UpdatesSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.User.UserSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Aggregates.UserName.UserNameSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.AppCodeCanceledEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.AppCodeCheckFailedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.AppCodeCheckSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.AppCodeCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.CheckSignInCodeCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.AppCode.CheckSignUpCodeCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelAboutEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelAdminRightsEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelColorUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelCreatorCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelDefaultBannedRightsEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelInviteDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelInviteEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelInviteExportedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelMemberBannedRightsChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelMemberCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelMemberJoinedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelMemberLeftEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelPhotoEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelTitleEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ChannelUserNameChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.CheckChannelStateCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ExportChatInviteEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.IncrementParticipantCountEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.NewMsgIdPinnedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.PreHistoryHiddenChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.ReadChannelLatestNoneBotOutboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.SetChannelPtsEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.SetDiscussionGroupEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.SlowModeChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.StartInviteToChannelEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Channel.StartSendChannelMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatAboutEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatAdminRightsEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatDefaultBannedRightsEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatMemberAddedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatMemberDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatPhotoEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ChatTitleEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.CheckChatStateCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ClearGroupChatHistoryStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.DeleteChatMessagesStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.NewChatMsgIdPinnedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.ReadLatestNoneBotOutboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Chat.StartSendChatMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Device.BindUidToDeviceEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Device.DeviceAuthKeyUnRegisteredEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Device.DeviceCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Device.DeviceRegisteredEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ChannelHistoryClearedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ClearChannelHistoryEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DeleteUserMessagesStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DialogCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DialogMsgIdPinnedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DialogPinChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DialogUnreadMarkChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DraftClearedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.DraftSavedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.HistoryClearedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.InboxMessageReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.OutboxAlreadyReadEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.OutboxMessageHasReadEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ParticipantHistoryClearedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.PinnedOrderChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ReadChannelInboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ReadInboxMessage2Event))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.SetOutboxTopMessageSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Dialog.ToggleDialogPinEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.CheckMessageViewLogSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.DeleteMessagesStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.DeleteParticipantHistoryStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.ForwardMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxItemsAddedToOutboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxMessageCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxMessageEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxMessageHasReadEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxMessageIdAddedToOutboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.InboxMessagePinnedUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.MessageDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.MessageForwardedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.MessageViewsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.OtherPartyMessageDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.OutboxMessageCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.OutboxMessageEditedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.OutboxMessagePinnedUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.ReadingHistoryCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.ReplyToMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.ReplyToMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.SelfMessageDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.SendMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Messaging.UpdatePinnedMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.PeerNotifySettings.PeerNotifySettingsUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Poll.PollClosedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Poll.PollCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsAckedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsForAuthKeyIdUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsGlobalSeqNoUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.PtsUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.QtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Pts.QtsUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.PushDevice.PushDeviceRegisteredEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.PushDevice.PushDeviceUnRegisteredEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.PushUpdates.EncryptedPushUpdatesCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.PushUpdates.PushUpdatesCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.QrCode.LoginTokenAcceptedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.QrCode.QrCodeLoginSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.QrCode.QrCodeLoginTokenExportedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.RpcResult.RpcResultCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.Updates.UpdatesCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.CheckUserStateCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.CheckUserStatusCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.SendUserMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserColorUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserNameUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserProfilePhotoChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserProfilePhotoUploadedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserProfileUpdatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserSupportHasSetEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.User.UserVerifiedHasSetEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.UserName.SetUserNameSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.UserName.UserNameCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Events.UserName.UserNameDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearHistoryPtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearHistorySagaCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearHistorySagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearPartialHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ClearSingleUserHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.CreateChannelSagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.CreateChannelSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteMessagePtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteMessageSaga2StartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteMessagesCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteMessagesSagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteOtherPartyMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteParticipantHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteParticipantHistoryPtsIncrementedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteParticipantHistorySagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteSelfMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.DeleteSingleMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.EditInboxMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.EditOutboxMessageStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ForwardMessageSagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ForwardSingleMessageSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.InboxMessageDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.InboxMessageEditCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.InviteToChannelCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.InviteToChannelSagaMemberCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.InviteToChannelSagaStartEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.OutboxMessageDeletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.OutboxMessageEditCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadChannelHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadChannelHistoryStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryInboxHasReadEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryOutboxHasReadEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryPtsIncrementEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryReadLatestNoneBotOutboxMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReadHistoryStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.ReceiveInboxMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.SendMessageSagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.SendOutboxMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.SignInStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.SignInSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.SignUpRequiredEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdateInboxPinnedCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdateOutboxPinnedCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdatePinnedBoxPtsCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdatePinnedCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdatePinnedMessageCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdatePinnedMessageSagaStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UpdateUserNameStartedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.UserSignUpSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.Events.VoteSagaCompletedEvent))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.States.ClearHistorySagaSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.States.ReadChannelHistorySagaSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.States.ReadHistorySagaSnapshot))]
[JsonSerializable(typeof(MyTelegram.Domain.Sagas.States.SignInSagaSnapshot))]


[JsonSerializable(typeof(UserReaction))]
[JsonSerializable(typeof(List<UserReaction>))]
[JsonSerializable(typeof(Reaction))]
[JsonSerializable(typeof(ReactionCount))]
[JsonSerializable(typeof(MyTelegram.Messenger.Handlers.Impl.CachedFutureSalt))]
[JsonSerializable(typeof(global::EventFlow.MongoDB.ValueObjects.MongoDbEventDataModel))]
[JsonSerializable(typeof(global::EventFlow.MongoDB.ValueObjects.MongoDbCounterDataModel))]
[JsonSerializable(typeof(global::EventFlow.MongoDB.ValueObjects.MongoDbSnapshotDataModel))]

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class MyMessengerJsonContext : JsonSerializerContext
{
}
