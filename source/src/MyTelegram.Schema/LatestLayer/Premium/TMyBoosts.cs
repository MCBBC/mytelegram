﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Premium;

///<summary>
/// A list of peers we are currently <a href="https://corefork.telegram.org/api/boost">boosting</a>, and how many <a href="https://corefork.telegram.org/api/boost">boost slots</a> we have left.
/// See <a href="https://corefork.telegram.org/constructor/premium.myBoosts" />
///</summary>
[TlObject(0x9ae228e2)]
public sealed class TMyBoosts : IMyBoosts
{
    public uint ConstructorId => 0x9ae228e2;
    ///<summary>
    /// Info about boosted peers and remaining boost slots.
    ///</summary>
    public TVector<MyTelegram.Schema.IMyBoost> MyBoosts { get; set; }

    ///<summary>
    /// Referenced chats
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Referenced users
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(MyBoosts);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        MyBoosts = reader.Read<TVector<MyTelegram.Schema.IMyBoost>>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}