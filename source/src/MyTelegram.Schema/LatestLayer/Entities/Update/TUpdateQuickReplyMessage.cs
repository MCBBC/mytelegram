﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/updateQuickReplyMessage" />
///</summary>
[TlObject(0x3e050d0f)]
public sealed class TUpdateQuickReplyMessage : IUpdate
{
    public uint ConstructorId => 0x3e050d0f;
    public MyTelegram.Schema.IMessage Message { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Message);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Message = reader.Read<MyTelegram.Schema.IMessage>();
    }
}