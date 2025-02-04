﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Get pinned <a href="https://corefork.telegram.org/api/saved-messages">saved dialogs, see here »</a> for more info.
/// See <a href="https://corefork.telegram.org/method/messages.getPinnedSavedDialogs" />
///</summary>
[TlObject(0xd63d94e0)]
public sealed class RequestGetPinnedSavedDialogs : IRequest<MyTelegram.Schema.Messages.ISavedDialogs>
{
    public uint ConstructorId => 0xd63d94e0;

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}
