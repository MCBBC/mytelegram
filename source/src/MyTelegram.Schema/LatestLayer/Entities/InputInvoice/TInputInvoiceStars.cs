﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/inputInvoiceStars" />
///</summary>
[TlObject(0x1da33ad8)]
public sealed class TInputInvoiceStars : IInputInvoice
{
    public uint ConstructorId => 0x1da33ad8;
    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/StarsTopupOption" />
    ///</summary>
    public MyTelegram.Schema.IStarsTopupOption Option { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Option);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Option = reader.Read<MyTelegram.Schema.IStarsTopupOption>();
    }
}