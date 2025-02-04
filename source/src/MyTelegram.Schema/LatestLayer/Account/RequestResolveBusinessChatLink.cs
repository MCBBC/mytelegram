﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// See <a href="https://corefork.telegram.org/method/account.resolveBusinessChatLink" />
///</summary>
[TlObject(0x5492e5ee)]
public sealed class RequestResolveBusinessChatLink : IRequest<MyTelegram.Schema.Account.IResolvedBusinessChatLinks>
{
    public uint ConstructorId => 0x5492e5ee;
    public string Slug { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Slug);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Slug = reader.ReadString();
    }
}
