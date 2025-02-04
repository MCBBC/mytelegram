﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// The <a href="https://corefork.telegram.org/api/wallpapers">wallpaper »</a> of a given peer has changed.
/// See <a href="https://corefork.telegram.org/constructor/updatePeerWallpaper" />
///</summary>
[TlObject(0xae3f101d)]
public sealed class TUpdatePeerWallpaper : IUpdate
{
    public uint ConstructorId => 0xae3f101d;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Whether the other user has chosen a custom wallpaper for us using <a href="https://corefork.telegram.org/method/messages.setChatWallPaper">messages.setChatWallPaper</a> and the <code>for_both</code> flag, see <a href="https://corefork.telegram.org/api/wallpapers#installing-wallpapers-in-a-specific-chat-or-channel">here »</a> for more info.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool WallpaperOverridden { get; set; }

    ///<summary>
    /// The peer where the wallpaper has changed.
    /// See <a href="https://corefork.telegram.org/type/Peer" />
    ///</summary>
    public MyTelegram.Schema.IPeer Peer { get; set; }

    ///<summary>
    /// The new wallpaper, if none the wallpaper was removed and the default wallpaper should be used.
    /// See <a href="https://corefork.telegram.org/type/WallPaper" />
    ///</summary>
    public MyTelegram.Schema.IWallPaper? Wallpaper { get; set; }

    public void ComputeFlag()
    {
        if (WallpaperOverridden) { Flags[1] = true; }
        if (Wallpaper != null) { Flags[0] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Peer);
        if (Flags[0]) { writer.Write(Wallpaper); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[1]) { WallpaperOverridden = true; }
        Peer = reader.Read<MyTelegram.Schema.IPeer>();
        if (Flags[0]) { Wallpaper = reader.Read<MyTelegram.Schema.IWallPaper>(); }
    }
}