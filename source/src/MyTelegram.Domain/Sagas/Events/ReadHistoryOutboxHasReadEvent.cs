﻿namespace MyTelegram.Domain.Sagas.Events;

public class ReadHistoryOutboxHasReadEvent(
    RequestInfo requestInfo,
    long senderPeerId,
    int senderMessageId)
    : RequestAggregateEvent2<ReadHistorySaga, ReadHistorySagaId>(requestInfo)
{
    public int SenderMessageId { get; } = senderMessageId;

    public long SenderPeerId { get; } = senderPeerId;
}
