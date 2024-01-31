﻿// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Object contains info on events occurred.
/// See <a href="https://corefork.telegram.org/constructor/Update" />
///</summary>
[JsonDerivedType(typeof(TUpdateNewMessage), nameof(TUpdateNewMessage))]
[JsonDerivedType(typeof(TUpdateMessageID), nameof(TUpdateMessageID))]
[JsonDerivedType(typeof(TUpdateDeleteMessages), nameof(TUpdateDeleteMessages))]
[JsonDerivedType(typeof(TUpdateUserTyping), nameof(TUpdateUserTyping))]
[JsonDerivedType(typeof(TUpdateChatUserTyping), nameof(TUpdateChatUserTyping))]
[JsonDerivedType(typeof(TUpdateChatParticipants), nameof(TUpdateChatParticipants))]
[JsonDerivedType(typeof(TUpdateUserStatus), nameof(TUpdateUserStatus))]
[JsonDerivedType(typeof(TUpdateUserName), nameof(TUpdateUserName))]
[JsonDerivedType(typeof(TUpdateNewAuthorization), nameof(TUpdateNewAuthorization))]
[JsonDerivedType(typeof(TUpdateNewEncryptedMessage), nameof(TUpdateNewEncryptedMessage))]
[JsonDerivedType(typeof(TUpdateEncryptedChatTyping), nameof(TUpdateEncryptedChatTyping))]
[JsonDerivedType(typeof(TUpdateEncryption), nameof(TUpdateEncryption))]
[JsonDerivedType(typeof(TUpdateEncryptedMessagesRead), nameof(TUpdateEncryptedMessagesRead))]
[JsonDerivedType(typeof(TUpdateChatParticipantAdd), nameof(TUpdateChatParticipantAdd))]
[JsonDerivedType(typeof(TUpdateChatParticipantDelete), nameof(TUpdateChatParticipantDelete))]
[JsonDerivedType(typeof(TUpdateDcOptions), nameof(TUpdateDcOptions))]
[JsonDerivedType(typeof(TUpdateNotifySettings), nameof(TUpdateNotifySettings))]
[JsonDerivedType(typeof(TUpdateServiceNotification), nameof(TUpdateServiceNotification))]
[JsonDerivedType(typeof(TUpdatePrivacy), nameof(TUpdatePrivacy))]
[JsonDerivedType(typeof(TUpdateUserPhone), nameof(TUpdateUserPhone))]
[JsonDerivedType(typeof(TUpdateReadHistoryInbox), nameof(TUpdateReadHistoryInbox))]
[JsonDerivedType(typeof(TUpdateReadHistoryOutbox), nameof(TUpdateReadHistoryOutbox))]
[JsonDerivedType(typeof(TUpdateWebPage), nameof(TUpdateWebPage))]
[JsonDerivedType(typeof(TUpdateReadMessagesContents), nameof(TUpdateReadMessagesContents))]
[JsonDerivedType(typeof(TUpdateChannelTooLong), nameof(TUpdateChannelTooLong))]
[JsonDerivedType(typeof(TUpdateChannel), nameof(TUpdateChannel))]
[JsonDerivedType(typeof(TUpdateNewChannelMessage), nameof(TUpdateNewChannelMessage))]
[JsonDerivedType(typeof(TUpdateReadChannelInbox), nameof(TUpdateReadChannelInbox))]
[JsonDerivedType(typeof(TUpdateDeleteChannelMessages), nameof(TUpdateDeleteChannelMessages))]
[JsonDerivedType(typeof(TUpdateChannelMessageViews), nameof(TUpdateChannelMessageViews))]
[JsonDerivedType(typeof(TUpdateChatParticipantAdmin), nameof(TUpdateChatParticipantAdmin))]
[JsonDerivedType(typeof(TUpdateNewStickerSet), nameof(TUpdateNewStickerSet))]
[JsonDerivedType(typeof(TUpdateStickerSetsOrder), nameof(TUpdateStickerSetsOrder))]
[JsonDerivedType(typeof(TUpdateStickerSets), nameof(TUpdateStickerSets))]
[JsonDerivedType(typeof(TUpdateSavedGifs), nameof(TUpdateSavedGifs))]
[JsonDerivedType(typeof(TUpdateBotInlineQuery), nameof(TUpdateBotInlineQuery))]
[JsonDerivedType(typeof(TUpdateBotInlineSend), nameof(TUpdateBotInlineSend))]
[JsonDerivedType(typeof(TUpdateEditChannelMessage), nameof(TUpdateEditChannelMessage))]
[JsonDerivedType(typeof(TUpdateBotCallbackQuery), nameof(TUpdateBotCallbackQuery))]
[JsonDerivedType(typeof(TUpdateEditMessage), nameof(TUpdateEditMessage))]
[JsonDerivedType(typeof(TUpdateInlineBotCallbackQuery), nameof(TUpdateInlineBotCallbackQuery))]
[JsonDerivedType(typeof(TUpdateReadChannelOutbox), nameof(TUpdateReadChannelOutbox))]
[JsonDerivedType(typeof(TUpdateDraftMessage), nameof(TUpdateDraftMessage))]
[JsonDerivedType(typeof(TUpdateReadFeaturedStickers), nameof(TUpdateReadFeaturedStickers))]
[JsonDerivedType(typeof(TUpdateRecentStickers), nameof(TUpdateRecentStickers))]
[JsonDerivedType(typeof(TUpdateConfig), nameof(TUpdateConfig))]
[JsonDerivedType(typeof(TUpdatePtsChanged), nameof(TUpdatePtsChanged))]
[JsonDerivedType(typeof(TUpdateChannelWebPage), nameof(TUpdateChannelWebPage))]
[JsonDerivedType(typeof(TUpdateDialogPinned), nameof(TUpdateDialogPinned))]
[JsonDerivedType(typeof(TUpdatePinnedDialogs), nameof(TUpdatePinnedDialogs))]
[JsonDerivedType(typeof(TUpdateBotWebhookJSON), nameof(TUpdateBotWebhookJSON))]
[JsonDerivedType(typeof(TUpdateBotWebhookJSONQuery), nameof(TUpdateBotWebhookJSONQuery))]
[JsonDerivedType(typeof(TUpdateBotShippingQuery), nameof(TUpdateBotShippingQuery))]
[JsonDerivedType(typeof(TUpdateBotPrecheckoutQuery), nameof(TUpdateBotPrecheckoutQuery))]
[JsonDerivedType(typeof(TUpdatePhoneCall), nameof(TUpdatePhoneCall))]
[JsonDerivedType(typeof(TUpdateLangPackTooLong), nameof(TUpdateLangPackTooLong))]
[JsonDerivedType(typeof(TUpdateLangPack), nameof(TUpdateLangPack))]
[JsonDerivedType(typeof(TUpdateFavedStickers), nameof(TUpdateFavedStickers))]
[JsonDerivedType(typeof(TUpdateChannelReadMessagesContents), nameof(TUpdateChannelReadMessagesContents))]
[JsonDerivedType(typeof(TUpdateContactsReset), nameof(TUpdateContactsReset))]
[JsonDerivedType(typeof(TUpdateChannelAvailableMessages), nameof(TUpdateChannelAvailableMessages))]
[JsonDerivedType(typeof(TUpdateDialogUnreadMark), nameof(TUpdateDialogUnreadMark))]
[JsonDerivedType(typeof(TUpdateMessagePoll), nameof(TUpdateMessagePoll))]
[JsonDerivedType(typeof(TUpdateChatDefaultBannedRights), nameof(TUpdateChatDefaultBannedRights))]
[JsonDerivedType(typeof(TUpdateFolderPeers), nameof(TUpdateFolderPeers))]
[JsonDerivedType(typeof(TUpdatePeerSettings), nameof(TUpdatePeerSettings))]
[JsonDerivedType(typeof(TUpdatePeerLocated), nameof(TUpdatePeerLocated))]
[JsonDerivedType(typeof(TUpdateNewScheduledMessage), nameof(TUpdateNewScheduledMessage))]
[JsonDerivedType(typeof(TUpdateDeleteScheduledMessages), nameof(TUpdateDeleteScheduledMessages))]
[JsonDerivedType(typeof(TUpdateTheme), nameof(TUpdateTheme))]
[JsonDerivedType(typeof(TUpdateGeoLiveViewed), nameof(TUpdateGeoLiveViewed))]
[JsonDerivedType(typeof(TUpdateLoginToken), nameof(TUpdateLoginToken))]
[JsonDerivedType(typeof(TUpdateMessagePollVote), nameof(TUpdateMessagePollVote))]
[JsonDerivedType(typeof(TUpdateDialogFilter), nameof(TUpdateDialogFilter))]
[JsonDerivedType(typeof(TUpdateDialogFilterOrder), nameof(TUpdateDialogFilterOrder))]
[JsonDerivedType(typeof(TUpdateDialogFilters), nameof(TUpdateDialogFilters))]
[JsonDerivedType(typeof(TUpdatePhoneCallSignalingData), nameof(TUpdatePhoneCallSignalingData))]
[JsonDerivedType(typeof(TUpdateChannelMessageForwards), nameof(TUpdateChannelMessageForwards))]
[JsonDerivedType(typeof(TUpdateReadChannelDiscussionInbox), nameof(TUpdateReadChannelDiscussionInbox))]
[JsonDerivedType(typeof(TUpdateReadChannelDiscussionOutbox), nameof(TUpdateReadChannelDiscussionOutbox))]
[JsonDerivedType(typeof(TUpdatePeerBlocked), nameof(TUpdatePeerBlocked))]
[JsonDerivedType(typeof(TUpdateChannelUserTyping), nameof(TUpdateChannelUserTyping))]
[JsonDerivedType(typeof(TUpdatePinnedMessages), nameof(TUpdatePinnedMessages))]
[JsonDerivedType(typeof(TUpdatePinnedChannelMessages), nameof(TUpdatePinnedChannelMessages))]
[JsonDerivedType(typeof(TUpdateChat), nameof(TUpdateChat))]
[JsonDerivedType(typeof(TUpdateGroupCallParticipants), nameof(TUpdateGroupCallParticipants))]
[JsonDerivedType(typeof(TUpdateGroupCall), nameof(TUpdateGroupCall))]
[JsonDerivedType(typeof(TUpdatePeerHistoryTTL), nameof(TUpdatePeerHistoryTTL))]
[JsonDerivedType(typeof(TUpdateChatParticipant), nameof(TUpdateChatParticipant))]
[JsonDerivedType(typeof(TUpdateChannelParticipant), nameof(TUpdateChannelParticipant))]
[JsonDerivedType(typeof(TUpdateBotStopped), nameof(TUpdateBotStopped))]
[JsonDerivedType(typeof(TUpdateGroupCallConnection), nameof(TUpdateGroupCallConnection))]
[JsonDerivedType(typeof(TUpdateBotCommands), nameof(TUpdateBotCommands))]
[JsonDerivedType(typeof(TUpdatePendingJoinRequests), nameof(TUpdatePendingJoinRequests))]
[JsonDerivedType(typeof(TUpdateBotChatInviteRequester), nameof(TUpdateBotChatInviteRequester))]
[JsonDerivedType(typeof(TUpdateMessageReactions), nameof(TUpdateMessageReactions))]
[JsonDerivedType(typeof(TUpdateAttachMenuBots), nameof(TUpdateAttachMenuBots))]
[JsonDerivedType(typeof(TUpdateWebViewResultSent), nameof(TUpdateWebViewResultSent))]
[JsonDerivedType(typeof(TUpdateBotMenuButton), nameof(TUpdateBotMenuButton))]
[JsonDerivedType(typeof(TUpdateSavedRingtones), nameof(TUpdateSavedRingtones))]
[JsonDerivedType(typeof(TUpdateTranscribedAudio), nameof(TUpdateTranscribedAudio))]
[JsonDerivedType(typeof(TUpdateReadFeaturedEmojiStickers), nameof(TUpdateReadFeaturedEmojiStickers))]
[JsonDerivedType(typeof(TUpdateUserEmojiStatus), nameof(TUpdateUserEmojiStatus))]
[JsonDerivedType(typeof(TUpdateRecentEmojiStatuses), nameof(TUpdateRecentEmojiStatuses))]
[JsonDerivedType(typeof(TUpdateRecentReactions), nameof(TUpdateRecentReactions))]
[JsonDerivedType(typeof(TUpdateMoveStickerSetToTop), nameof(TUpdateMoveStickerSetToTop))]
[JsonDerivedType(typeof(TUpdateMessageExtendedMedia), nameof(TUpdateMessageExtendedMedia))]
[JsonDerivedType(typeof(TUpdateChannelPinnedTopic), nameof(TUpdateChannelPinnedTopic))]
[JsonDerivedType(typeof(TUpdateChannelPinnedTopics), nameof(TUpdateChannelPinnedTopics))]
[JsonDerivedType(typeof(TUpdateUser), nameof(TUpdateUser))]
[JsonDerivedType(typeof(TUpdateAutoSaveSettings), nameof(TUpdateAutoSaveSettings))]
[JsonDerivedType(typeof(TUpdateGroupInvitePrivacyForbidden), nameof(TUpdateGroupInvitePrivacyForbidden))]
[JsonDerivedType(typeof(TUpdateStory), nameof(TUpdateStory))]
[JsonDerivedType(typeof(TUpdateReadStories), nameof(TUpdateReadStories))]
[JsonDerivedType(typeof(TUpdateStoryID), nameof(TUpdateStoryID))]
[JsonDerivedType(typeof(TUpdateStoriesStealthMode), nameof(TUpdateStoriesStealthMode))]
[JsonDerivedType(typeof(TUpdateSentStoryReaction), nameof(TUpdateSentStoryReaction))]
[JsonDerivedType(typeof(TUpdateBotChatBoost), nameof(TUpdateBotChatBoost))]
[JsonDerivedType(typeof(TUpdateChannelViewForumAsMessages), nameof(TUpdateChannelViewForumAsMessages))]
[JsonDerivedType(typeof(TUpdatePeerWallpaper), nameof(TUpdatePeerWallpaper))]
[JsonDerivedType(typeof(TUpdateBotMessageReaction), nameof(TUpdateBotMessageReaction))]
[JsonDerivedType(typeof(TUpdateBotMessageReactions), nameof(TUpdateBotMessageReactions))]
[JsonDerivedType(typeof(TUpdateSavedDialogPinned), nameof(TUpdateSavedDialogPinned))]
[JsonDerivedType(typeof(TUpdatePinnedSavedDialogs), nameof(TUpdatePinnedSavedDialogs))]
[JsonDerivedType(typeof(TUpdateSavedReactionTags), nameof(TUpdateSavedReactionTags))]
public interface IUpdate : IObject
{

}
