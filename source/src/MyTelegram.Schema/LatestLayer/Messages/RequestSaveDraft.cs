﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Save a message <a href="https://corefork.telegram.org/api/drafts">draft</a> associated to a chat.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 ENTITY_BOUNDS_INVALID A specified <a href="https://corefork.telegram.org/api/entities#entity-length">entity offset or length</a> is invalid, see <a href="https://corefork.telegram.org/api/entities#entity-length">here »</a> for info on how to properly compute the entity offset/length.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.saveDraft" />
///</summary>
[TlObject(0x7ff3b806)]
public sealed class RequestSaveDraft : IRequest<IBool>
{
    public uint ConstructorId => 0x7ff3b806;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Disable generation of the webpage preview
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool NoWebpage { get; set; }

    ///<summary>
    /// If set, any eventual webpage preview will be shown on top of the message instead of at the bottom.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool InvertMedia { get; set; }

    ///<summary>
    /// If set, indicates that the message should be sent in reply to the specified message or story.
    /// See <a href="https://corefork.telegram.org/type/InputReplyTo" />
    ///</summary>
    public MyTelegram.Schema.IInputReplyTo? ReplyTo { get; set; }

    ///<summary>
    /// Destination of the message that should be sent
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// The draft
    ///</summary>
    public string Message { get; set; }

    ///<summary>
    /// Message <a href="https://corefork.telegram.org/api/entities">entities</a> for styled text
    ///</summary>
    public TVector<MyTelegram.Schema.IMessageEntity>? Entities { get; set; }

    ///<summary>
    /// Attached media
    /// See <a href="https://corefork.telegram.org/type/InputMedia" />
    ///</summary>
    public MyTelegram.Schema.IInputMedia? Media { get; set; }

    public void ComputeFlag()
    {
        if (NoWebpage) { Flags[1] = true; }
        if (InvertMedia) { Flags[6] = true; }
        if (ReplyTo != null) { Flags[4] = true; }
        if (Entities?.Count > 0) { Flags[3] = true; }
        if (Media != null) { Flags[5] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[4]) { writer.Write(ReplyTo); }
        writer.Write(Peer);
        writer.Write(Message);
        if (Flags[3]) { writer.Write(Entities); }
        if (Flags[5]) { writer.Write(Media); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { NoWebpage = true; }
        if (Flags[6]) { InvertMedia = true; }
        if (Flags[4]) { ReplyTo = reader.Read<MyTelegram.Schema.IInputReplyTo>(); }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Message = reader.ReadString();
        if (Flags[3]) { Entities = reader.Read<TVector<MyTelegram.Schema.IMessageEntity>>(); }
        if (Flags[5]) { Media = reader.Read<MyTelegram.Schema.IInputMedia>(); }
    }
}
