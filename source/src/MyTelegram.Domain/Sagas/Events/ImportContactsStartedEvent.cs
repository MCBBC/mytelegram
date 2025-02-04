﻿namespace MyTelegram.Domain.Sagas.Events;

public class ImportContactsStartedEvent(
    RequestInfo requestInfo,
    int count) : RequestAggregateEvent2<ImportContactsSaga, ImportContactsSagaId>(requestInfo)
{
    public int Count { get; } = count;
}
