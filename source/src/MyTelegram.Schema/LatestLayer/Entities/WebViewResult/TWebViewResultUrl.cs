﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains the webview URL with appropriate theme and user info parameters added
/// See <a href="https://corefork.telegram.org/constructor/webViewResultUrl" />
///</summary>
[TlObject(0x4d22ff98)]
public sealed class TWebViewResultUrl : IWebViewResult
{
    public uint ConstructorId => 0x4d22ff98;
    public BitArray Flags { get; set; } = new BitArray(32);
    public bool Fullsize { get; set; }

    ///<summary>
    /// Webview session ID
    ///</summary>
    public long? QueryId { get; set; }

    ///<summary>
    /// Webview URL to open
    ///</summary>
    public string Url { get; set; }

    public void ComputeFlag()
    {
        if (Fullsize) { Flags[1] = true; }
        if (/*QueryId != 0 &&*/ QueryId.HasValue) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        if (Flags[0]) { writer.Write(QueryId.Value); }
        writer.Write(Url);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { Fullsize = true; }
        if (Flags[0]) { QueryId = reader.ReadInt64(); }
        Url = reader.ReadString();
    }
}