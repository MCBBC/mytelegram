﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/account.connectedBots" />
///</summary>
[TlObject(0x17d7f87b)]
public sealed class TConnectedBots : IConnectedBots
{
    public uint ConstructorId => 0x17d7f87b;
    public TVector<MyTelegram.Schema.IConnectedBot> ConnectedBots { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ConnectedBots);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ConnectedBots = reader.Read<TVector<MyTelegram.Schema.IConnectedBot>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}