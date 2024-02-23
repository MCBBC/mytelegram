﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xae500895)]
public sealed class TFutureSalts : IFutureSalts
{
    public uint ConstructorId => 0xae500895;
    public long ReqMsgId { get; set; }
    public int Now { get; set; }
    public TVector<MyTelegram.Schema.IFutureSalt> Salts { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ReqMsgId);
        writer.Write(Now);
        //writer.Write(Salts);

        // future_salts#ae500895 req_msg_id:long now:int salts:vector<future_salt> = FutureSalts;

        writer.Write(Salts.Count);
        foreach (var futureSalt in Salts)
        {
            writer.Write(futureSalt.ValidSince);
            writer.Write(futureSalt.ValidUntil);
            writer.Write(futureSalt.Salt);
        }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ReqMsgId = reader.ReadInt64();
        Now = reader.ReadInt32();
        //Salts = reader.Read<TVector<MyTelegram.Schema.IFutureSalt>>();
        var count = reader.ReadInt32();
        Salts = new TVector<IFutureSalt>();
        for (int i = 0; i < count; i++)
        {
            var futureSalt = reader.Read<IFutureSalt>();
            Salts.Add(futureSalt);
        }
    }
}