﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stats;

///<summary>
/// Message statistics
/// See <a href="https://corefork.telegram.org/constructor/stats.messageStats" />
///</summary>
[TlObject(0x7fe91c14)]
public sealed class TMessageStats : IMessageStats
{
    public uint ConstructorId => 0x7fe91c14;
    ///<summary>
    /// Message view graph
    /// See <a href="https://corefork.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph ViewsGraph { get; set; }

    ///<summary>
    /// A graph containing the number of reactions on stories categorized by emotion
    /// See <a href="https://corefork.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph ReactionsByEmotionGraph { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(ViewsGraph);
        writer.Write(ReactionsByEmotionGraph);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        ViewsGraph = reader.Read<MyTelegram.Schema.IStatsGraph>();
        ReactionsByEmotionGraph = reader.Read<MyTelegram.Schema.IStatsGraph>();
    }
}