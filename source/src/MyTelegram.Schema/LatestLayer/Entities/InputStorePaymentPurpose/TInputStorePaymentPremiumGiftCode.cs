﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Used to gift <a href="https://corefork.telegram.org/api/premium">Telegram Premium</a> subscriptions only to some specific subscribers of a channel or to some of our contacts, see <a href="https://corefork.telegram.org/api/giveaways">here »</a> for more info on giveaways and gifts.
/// See <a href="https://corefork.telegram.org/constructor/inputStorePaymentPremiumGiftCode" />
///</summary>
[TlObject(0xa3805f3f)]
public sealed class TInputStorePaymentPremiumGiftCode : IInputStorePaymentPurpose
{
    public uint ConstructorId => 0xa3805f3f;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// The users that will receive the <a href="https://corefork.telegram.org/api/premium">Telegram Premium</a> subscriptions.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputUser> Users { get; set; }

    ///<summary>
    /// If set, the gifts will be sent on behalf of a channel we are an admin of, which will also assign some <a href="https://corefork.telegram.org/api/boost">boosts</a> to it. Otherwise, the gift will be sent directly from the currently logged in users, and we will gain some extra <a href="https://corefork.telegram.org/api/boost">boost slots</a>. See <a href="https://corefork.telegram.org/api/giveaways">here »</a> for more info on giveaways and gifts.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer? BoostPeer { get; set; }

    ///<summary>
    /// Three-letter ISO 4217 <a href="https://corefork.telegram.org/bots/payments#supported-currencies">currency</a> code
    ///</summary>
    public string Currency { get; set; }

    ///<summary>
    /// Total price in the smallest units of the currency (integer, not float/double). For example, for a price of <code>US$ 1.45</code> pass <code>amount = 145</code>. See the exp parameter in <a href="https://corefork.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    ///</summary>
    public long Amount { get; set; }

    public void ComputeFlag()
    {
        if (BoostPeer != null) { Flags[0] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(Users);
        if (Flags[0]) { writer.Write(BoostPeer); }
        writer.Write(Currency);
        writer.Write(Amount);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        Users = reader.Read<TVector<MyTelegram.Schema.IInputUser>>();
        if (Flags[0]) { BoostPeer = reader.Read<MyTelegram.Schema.IInputPeer>(); }
        Currency = reader.ReadString();
        Amount = reader.ReadInt64();
    }
}