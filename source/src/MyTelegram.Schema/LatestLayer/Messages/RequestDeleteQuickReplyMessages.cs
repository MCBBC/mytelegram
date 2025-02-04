﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// See <a href="https://corefork.telegram.org/method/messages.deleteQuickReplyMessages" />
///</summary>
[TlObject(0xe105e910)]
public sealed class RequestDeleteQuickReplyMessages : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xe105e910;
    public int ShortcutId { get; set; }
    public TVector<int> Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ShortcutId);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ShortcutId = reader.ReadInt32();
        Id = reader.Read<TVector<int>>();
    }
}
