﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Reply to a story.
/// See <a href="https://corefork.telegram.org/constructor/inputReplyToStory" />
///</summary>
[TlObject(0x15b0f283)]
public sealed class TInputReplyToStory : IInputReplyTo
{
    public uint ConstructorId => 0x15b0f283;
    ///<summary>
    /// ID of the user that posted the story.
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser UserId { get; set; }

    ///<summary>
    /// ID of the story to reply to.
    ///</summary>
    public int StoryId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(StoryId);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.Read<MyTelegram.Schema.IInputUser>();
        StoryId = reader.ReadInt32();
    }
}