﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Edit the default banned rights of a <a href="https://corefork.telegram.org/api/channel">channel/supergroup/group</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BANNED_RIGHTS_INVALID You provided some invalid flags in the banned rights.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 CHAT_ADMIN_REQUIRED You must be an admin in this chat to do this.
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 CHAT_NOT_MODIFIED No changes were made to chat information because the new information you passed is identical to the current information.
/// 403 CHAT_WRITE_FORBIDDEN You can't write in this chat.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// 400 UNTIL_DATE_INVALID Invalid until date provided.
/// See <a href="https://corefork.telegram.org/method/messages.editChatDefaultBannedRights" />
///</summary>
[TlObject(0xa5866b41)]
public sealed class RequestEditChatDefaultBannedRights : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xa5866b41;
    ///<summary>
    /// The peer
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// The new global rights
    /// See <a href="https://corefork.telegram.org/type/ChatBannedRights" />
    ///</summary>
    public MyTelegram.Schema.IChatBannedRights BannedRights { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(BannedRights);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        BannedRights = reader.Read<MyTelegram.Schema.IChatBannedRights>();
    }
}
