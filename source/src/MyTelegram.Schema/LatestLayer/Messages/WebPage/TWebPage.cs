﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Represents an Instant View webpage.
/// See <a href="https://corefork.telegram.org/constructor/messages.webPage" />
///</summary>
[TlObject(0xfd5e12bd)]
public sealed class TWebPage : IWebPage
{
    public uint ConstructorId => 0xfd5e12bd;
    ///<summary>
    /// The instant view webpage.
    /// See <a href="https://corefork.telegram.org/type/WebPage" />
    ///</summary>
    public MyTelegram.Schema.IWebPage Webpage { get; set; }

    ///<summary>
    /// Chats mentioned in the webpage.
    ///</summary>
    public TVector<MyTelegram.Schema.IChat> Chats { get; set; }

    ///<summary>
    /// Users mentioned in the webpage.
    ///</summary>
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Webpage);
        writer.Write(Chats);
        writer.Write(Users);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Webpage = reader.Read<MyTelegram.Schema.IWebPage>();
        Chats = reader.Read<TVector<MyTelegram.Schema.IChat>>();
        Users = reader.Read<TVector<MyTelegram.Schema.IUser>>();
    }
}