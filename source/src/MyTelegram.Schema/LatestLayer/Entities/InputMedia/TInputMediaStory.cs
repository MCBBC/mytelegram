﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Forwarded story
/// See <a href="https://corefork.telegram.org/constructor/inputMediaStory" />
///</summary>
[TlObject(0x89fdd778)]
public sealed class TInputMediaStory : IInputMedia
{
    public uint ConstructorId => 0x89fdd778;
    ///<summary>
    /// Peer where the story was posted
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Story ID
    ///</summary>
    public int Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Id);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Id = reader.ReadInt32();
    }
}