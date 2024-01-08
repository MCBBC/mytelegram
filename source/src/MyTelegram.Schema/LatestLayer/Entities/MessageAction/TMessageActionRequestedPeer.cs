﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains info about a peer that the user shared with the bot after clicking on a <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a> button.
/// See <a href="https://corefork.telegram.org/constructor/messageActionRequestedPeer" />
///</summary>
[TlObject(0x31518e9b)]
public sealed class TMessageActionRequestedPeer : IMessageAction
{
    public uint ConstructorId => 0x31518e9b;
    ///<summary>
    /// <code>button_id</code> contained in the <a href="https://corefork.telegram.org/constructor/keyboardButtonRequestPeer">keyboardButtonRequestPeer</a>
    ///</summary>
    public int ButtonId { get; set; }
    public TVector<MyTelegram.Schema.IPeer> Peers { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ButtonId);
        writer.Write(Peers);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ButtonId = reader.ReadInt32();
        Peers = reader.Read<TVector<MyTelegram.Schema.IPeer>>();
    }
}