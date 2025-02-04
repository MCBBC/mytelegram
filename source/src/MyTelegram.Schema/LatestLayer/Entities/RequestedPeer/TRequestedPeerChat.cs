﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/requestedPeerChat" />
///</summary>
[TlObject(0x7307544f)]
public sealed class TRequestedPeerChat : IRequestedPeer
{
    public uint ConstructorId => 0x7307544f;
    public BitArray Flags { get; set; } = new BitArray(32);
    public long ChatId { get; set; }
    public string? Title { get; set; }
    public MyTelegram.Schema.IPhoto? Photo { get; set; }

    public void ComputeFlag()
    {
        if (Title != null) { Flags[0] = true; }
        if (Photo != null) { Flags[2] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(ChatId);
        if (Flags[0]) { writer.Write(Title); }
        if (Flags[2]) { writer.Write(Photo); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        ChatId = reader.ReadInt64();
        if (Flags[0]) { Title = reader.ReadString(); }
        if (Flags[2]) { Photo = reader.Read<MyTelegram.Schema.IPhoto>(); }
    }
}