﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/updateSavedReactionTags" />
///</summary>
[TlObject(0x39c67432)]
public sealed class TUpdateSavedReactionTags : IUpdate
{
    public uint ConstructorId => 0x39c67432;


    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);

    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {

    }
}