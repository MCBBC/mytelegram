﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Open a <a href="https://corefork.telegram.org/bots/webapps">bot mini app</a>, sending over user information after user confirmation.After calling this method, until the user closes the webview, <a href="https://corefork.telegram.org/method/messages.prolongWebView">messages.prolongWebView</a> must be called every 60 seconds.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 BOT_INVALID This is not a valid bot.
/// 400 PEER_ID_INVALID The provided peer id is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.requestWebView" />
///</summary>
[TlObject(0x269dc2c1)]
public sealed class RequestRequestWebView : IRequest<MyTelegram.Schema.IWebViewResult>
{
    public uint ConstructorId => 0x269dc2c1;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the webview was opened by clicking on the bot's <a href="https://corefork.telegram.org/api/bots/menu">menu button »</a>.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool FromBotMenu { get; set; }

    ///<summary>
    /// Whether the inline message that will be sent by the bot on behalf of the user once the web app interaction is <a href="https://corefork.telegram.org/method/messages.sendWebViewResultMessage">terminated</a> should be sent silently (no notifications for the receivers).
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool Silent { get; set; }

    ///<summary>
    /// Dialog where the web app is being opened, and where the resulting message will be sent (see the <a href="https://corefork.telegram.org/api/bots/webapps">docs for more info »</a>).
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }

    ///<summary>
    /// Bot that owns the <a href="https://corefork.telegram.org/api/bots/webapps">web app</a>
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/bots/webapps">Web app URL</a>
    ///</summary>
    public string? Url { get; set; }

    ///<summary>
    /// If the web app was opened from the attachment menu using a <a href="https://corefork.telegram.org/api/links#bot-attachment-or-side-menu-links">attachment menu deep link</a>, <code>start_param</code> should contain the <code>data</code> from the <code>startattach</code> parameter.
    ///</summary>
    public string? StartParam { get; set; }

    ///<summary>
    /// <a href="https://corefork.telegram.org/api/bots/webapps#theme-parameters">Theme parameters »</a>
    /// See <a href="https://corefork.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON? ThemeParams { get; set; }

    ///<summary>
    /// Short name of the application; 0-64 English letters, digits, and underscores
    ///</summary>
    public string Platform { get; set; }

    ///<summary>
    /// If set, indicates that the inline message that will be sent by the bot on behalf of the user once the web app interaction is <a href="https://corefork.telegram.org/method/messages.sendWebViewResultMessage">terminated</a> should be sent in reply to the specified message or story.
    /// See <a href="https://corefork.telegram.org/type/InputReplyTo" />
    ///</summary>
    public MyTelegram.Schema.IInputReplyTo? ReplyTo { get; set; }

    ///<summary>
    /// Open the web app as the specified peer, sending the resulting the message as the specified peer.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? SendAs { get; set; }

    public void ComputeFlag()
    {
        if (FromBotMenu) { Flags[4] = true; }
        if (Silent) { Flags[5] = true; }
        if (Url != null) { Flags[1] = true; }
        if (StartParam != null) { Flags[3] = true; }
        if (ThemeParams != null) { Flags[2] = true; }
        if (ReplyTo != null) { Flags[0] = true; }
        if (SendAs != null) { Flags[13] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        writer.Write(Bot);
        if (Flags[1]) { writer.Write(Url); }
        if (Flags[3]) { writer.Write(StartParam); }
        if (Flags[2]) { writer.Write(ThemeParams); }
        writer.Write(Platform);
        if (Flags[0]) { writer.Write(ReplyTo); }
        if (Flags[13]) { writer.Write(SendAs); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[4]) { FromBotMenu = true; }
        if (Flags[5]) { Silent = true; }
        Peer = reader.Read<MyTelegram.Schema.IInputPeer>();
        Bot = reader.Read<MyTelegram.Schema.IInputUser>();
        if (Flags[1]) { Url = reader.ReadString(); }
        if (Flags[3]) { StartParam = reader.ReadString(); }
        if (Flags[2]) { ThemeParams = reader.Read<MyTelegram.Schema.IDataJSON>(); }
        Platform = reader.ReadString();
        if (Flags[0]) { ReplyTo = reader.Read<MyTelegram.Schema.IInputReplyTo>(); }
        if (Flags[13]) { SendAs = reader.Read<MyTelegram.Schema.IInputPeer>(); }
    }
}
