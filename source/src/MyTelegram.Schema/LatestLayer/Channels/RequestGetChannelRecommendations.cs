﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// Obtain a list of similarly themed public channels, selected based on similarities in their <strong>subscriber bases</strong>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// See <a href="https://corefork.telegram.org/method/channels.getChannelRecommendations" />
///</summary>
[TlObject(0x83b70d97)]
public sealed class RequestGetChannelRecommendations : IRequest<MyTelegram.Schema.Messages.IChats>
{
    public uint ConstructorId => 0x83b70d97;
    ///<summary>
    /// The method will return channels related to the passed <code>channel</code>.
    /// See <a href="https://corefork.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Channel);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Channel = reader.Read<MyTelegram.Schema.IInputChannel>();
    }
}
