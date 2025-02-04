﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/foundStory" />
///</summary>
[TlObject(0xe87acbc0)]
public sealed class TFoundStory : IFoundStory
{
    public uint ConstructorId => 0xe87acbc0;
    public MyTelegram.Schema.IPeer Peer { get; set; }
    public MyTelegram.Schema.IStoryItem Story { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Peer);
        writer.Write(Story);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        Story = reader.Read<MyTelegram.Schema.IStoryItem>();
    }
}