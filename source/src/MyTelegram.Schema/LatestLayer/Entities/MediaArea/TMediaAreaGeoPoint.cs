﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Represents a geolocation tag attached to a <a href="https://corefork.telegram.org/api/stories">story</a>.
/// See <a href="https://corefork.telegram.org/constructor/mediaAreaGeoPoint" />
///</summary>
[TlObject(0xcad5452d)]
public sealed class TMediaAreaGeoPoint : IMediaArea
{
    public uint ConstructorId => 0xcad5452d;
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// The size and position of the media area corresponding to the location sticker on top of the story media.
    /// See <a href="https://corefork.telegram.org/type/MediaAreaCoordinates" />
    ///</summary>
    public MyTelegram.Schema.IMediaAreaCoordinates Coordinates { get; set; }

    ///<summary>
    /// Coordinates of the geolocation tag.
    /// See <a href="https://corefork.telegram.org/type/GeoPoint" />
    ///</summary>
    public MyTelegram.Schema.IGeoPoint Geo { get; set; }
    public MyTelegram.Schema.IGeoPointAddress? Address { get; set; }

    public void ComputeFlag()
    {
        if (Address != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Coordinates);
        writer.Write(Geo);
        if (Flags[0]) { writer.Write(Address); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Coordinates = reader.Read<MyTelegram.Schema.IMediaAreaCoordinates>();
        Geo = reader.Read<MyTelegram.Schema.IGeoPoint>();
        if (Flags[0]) { Address = reader.Read<MyTelegram.Schema.IGeoPointAddress>(); }
    }
}