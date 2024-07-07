﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/messages.availableEffects" />
///</summary>
[TlObject(0xbddb616e)]
public sealed class TAvailableEffects : IAvailableEffects
{
    public uint ConstructorId => 0xbddb616e;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public int Hash { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IAvailableEffect> Effects { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public TVector<MyTelegram.Schema.IDocument> Documents { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Hash);
        writer.Write(Effects);
        writer.Write(Documents);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt32();
        Effects = reader.Read<TVector<MyTelegram.Schema.IAvailableEffect>>();
        Documents = reader.Read<TVector<MyTelegram.Schema.IDocument>>();
    }
}