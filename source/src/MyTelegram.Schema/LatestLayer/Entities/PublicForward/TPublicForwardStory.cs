﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains info about a forward of a <a href="https://corefork.telegram.org/api/stories">story</a> as a repost by a public channel.
/// See <a href="https://corefork.telegram.org/constructor/publicForwardStory" />
///</summary>
[TlObject(0xedf3add0)]
public sealed class TPublicForwardStory : IPublicForward
{
    public uint ConstructorId => 0xedf3add0;
    ///<summary>
    /// The channel that reposted the story.
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// The reposted story (may be different from the original story).
    /// See <a href="https://corefork.telegram.org/type/StoryItem" />
    ///</summary>
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