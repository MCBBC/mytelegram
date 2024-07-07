﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Payments;

///<summary>
/// See <a href="https://corefork.telegram.org/method/payments.refundStarsCharge" />
///</summary>
[TlObject(0x25ae8f4a)]
public sealed class RequestRefundStarsCharge : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x25ae8f4a;
    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string ChargeId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(ChargeId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.Read<MyTelegram.Schema.IInputUser>();
        ChargeId = reader.ReadString();
    }
}
