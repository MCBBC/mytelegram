﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/availableEffect" />
///</summary>
[TlObject(0x93c3e27e)]
public sealed class TAvailableEffect : IAvailableEffect
{
    public uint ConstructorId => 0x93c3e27e;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// &nbsp;
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool PremiumRequired { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public string Emoticon { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long? StaticIconId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long EffectStickerId { get; set; }

    ///<summary>
    /// &nbsp;
    ///</summary>
    public long? EffectAnimationId { get; set; }

    public void ComputeFlag()
    {
        if (PremiumRequired) { Flags[2] = true; }
        if (/*StaticIconId != 0 &&*/ StaticIconId.HasValue) { Flags[0] = true; }
        if (/*EffectAnimationId != 0 &&*/ EffectAnimationId.HasValue) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Id);
        writer.Write(Emoticon);
        if (Flags[0]) { writer.Write(StaticIconId.Value); }
        writer.Write(EffectStickerId);
        if (Flags[1]) { writer.Write(EffectAnimationId.Value); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[2]) { PremiumRequired = true; }
        Id = reader.ReadInt64();
        Emoticon = reader.ReadString();
        if (Flags[0]) { StaticIconId = reader.ReadInt64(); }
        EffectStickerId = reader.ReadInt64();
        if (Flags[1]) { EffectAnimationId = reader.ReadInt64(); }
    }
}