﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/inputMediaPaidMedia" />
///</summary>
[TlObject(0xaa661fc3)]
public sealed class TInputMediaPaidMedia : IInputMedia
{
    public uint ConstructorId => 0xaa661fc3;
    public long StarsAmount { get; set; }
    public TVector<MyTelegram.Schema.IInputMedia> ExtendedMedia { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(StarsAmount);
        writer.Write(ExtendedMedia);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        StarsAmount = reader.ReadInt64();
        ExtendedMedia = reader.Read<TVector<MyTelegram.Schema.IInputMedia>>();
    }
}