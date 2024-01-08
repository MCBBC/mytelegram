﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Set whether all users <a href="https://corefork.telegram.org/api/discussion#requiring-users-to-join-the-group">should join a discussion group in order to comment on a post »</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// See <a href="https://corefork.telegram.org/method/channels.toggleJoinToSend" />
///</summary>
[TlObject(0xe4cb9580)]
public sealed class RequestToggleJoinToSend : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xe4cb9580;
    ///<summary>
    /// Discussion group
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    /// Toggle
    /// See <a href="https://corefork.telegram.org/type/Bool" />
    ///</summary>
    public bool Enabled { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
        writer.Write(Enabled);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
        Enabled = reader.Read();
    }
}
