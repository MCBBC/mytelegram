﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Sends a text message to a secret chat.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHAT_ID_INVALID The provided chat id is invalid.
/// 400 DATA_INVALID Encrypted data invalid.
/// 400 DATA_TOO_LONG Data too long.
/// 400 ENCRYPTION_DECLINED The secret chat was declined.
/// 500 MSG_WAIT_FAILED A waiting call returned an error.
/// 403 USER_IS_BLOCKED You were blocked by this user.
/// See <a href="https://corefork.telegram.org/method/messages.sendEncrypted" />
///</summary>
[TlObject(0x44fa7a15)]
public sealed class RequestSendEncrypted : IRequest<MyTelegram.Schema.Messages.ISentEncryptedMessage>
{
    public uint ConstructorId => 0x44fa7a15;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Send encrypted message without a notification
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Secret chat ID
    /// See <a href="https://corefork.telegram.org/type/InputEncryptedChat" />
    ///</summary>
    public MyTelegram.Schema.IInputEncryptedChat Peer { get; set; }

    ///<summary>
    /// Unique client message ID, necessary to avoid message resending
    ///</summary>
    public long RandomId { get; set; }

    ///<summary>
    /// TL-serialization of <a href="https://corefork.telegram.org/type/DecryptedMessage">DecryptedMessage</a> type, encrypted with a key that was created during chat initialization
    ///</summary>
    public byte[] Data { get; set; }

    public void ComputeFlag()
    {
        if (Silent) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(RandomId);
        writer.Write(Data);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { Silent = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputEncryptedChat>();
        RandomId = reader.ReadInt64();
        Data = reader.ReadBytes();
    }
}
