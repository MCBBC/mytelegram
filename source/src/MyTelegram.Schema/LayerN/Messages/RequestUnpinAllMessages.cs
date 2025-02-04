﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages.LayerN;

///<summary>
/// <a href="https://corefork.telegram.org/api/pin">Unpin</a> all pinned messages
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// See <a href="https://corefork.telegram.org/method/messages.unpinAllMessages" />
///</summary>
[TlObject(0xf025bc8b)]
public sealed class RequestUnpinAllMessages : IRequest<MyTelegram.Schema.Messages.IAffectedHistory>
{
    public uint ConstructorId => 0xf025bc8b;

    ///<summary>
    /// Chat where to unpin
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    public void ComputeFlag()
    {
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
    }
}
