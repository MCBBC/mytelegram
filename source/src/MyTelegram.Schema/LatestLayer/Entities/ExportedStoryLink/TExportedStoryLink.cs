﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Represents a <a href="https://corefork.telegram.org/api/stories#story-links">story deep link</a>.
/// See <a href="https://corefork.telegram.org/constructor/exportedStoryLink" />
///</summary>
[TlObject(0x3fc9053b)]
public sealed class TExportedStoryLink : IExportedStoryLink
{
    public uint ConstructorId => 0x3fc9053b;
    ///<summary>
    /// The <a href="https://corefork.telegram.org/api/stories#story-links">story deep link</a>.
    ///</summary>
    public string Link { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Link);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Link = reader.ReadString();
    }
}