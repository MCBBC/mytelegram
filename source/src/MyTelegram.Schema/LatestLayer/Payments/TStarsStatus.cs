﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/payments.starsStatus" />
///</summary>
[TlObject(0x8cf4ee60)]
public sealed class TStarsStatus : IStarsStatus
{
    public uint ConstructorId => 0x8cf4ee60;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long Balance { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IStarsTransaction> History { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string? NextOffset { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {
        if (NextOffset != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Balance);
        writer.Write(History);
        if (Flags[0]) { writer.Write(NextOffset); }
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Balance = reader.ReadInt64();
        History = reader.Read<TVector<MyTelegram.Schema.IStarsTransaction>>();
        if (Flags[0]) { NextOffset = reader.ReadString(); }
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}