﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Used to pay for a <a href="https://corefork.telegram.org/api/giveaways">giveaway, see here »</a> for more info.
/// See <a href="https://corefork.telegram.org/constructor/inputStorePaymentPremiumGiveaway" />
///</summary>
[TlObject(0x160544ca)]
public sealed class TInputStorePaymentPremiumGiveaway : IInputStorePaymentPurpose
{
    public uint ConstructorId => 0x160544ca;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// If set, only new subscribers starting from the giveaway creation date will be able to participate to the giveaway.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool OnlyNewSubscribers { get; set; }

    ///<summary>
    /// If set, giveaway winners are public and will be listed in a <a href="https://corefork.telegram.org/constructor/messageMediaGiveawayResults">messageMediaGiveawayResults</a> message that will be automatically sent to the channel once the giveaway ends.
    /// See <a href="https://corefork.telegram.org/type/true" />
    ///</summary>
    public bool WinnersAreVisible { get; set; }

    ///<summary>
    /// The channel starting the giveaway, that the user must join to participate, that will receive the giveaway <a href="https://corefork.telegram.org/api/boost">boosts</a>; see <a href="https://corefork.telegram.org/api/giveaways">here »</a> for more info on giveaways.
    /// See <a href="https://corefork.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer BoostPeer { get; set; }

    ///<summary>
    /// Additional channels that the user must join to participate to the giveaway can be specified here.
    ///</summary>
    public TVector<MyTelegram.Schema.IInputPeer>? AdditionalPeers { get; set; }

    ///<summary>
    /// The set of users that can participate to the giveaway can be restricted by passing here an explicit whitelist of up to <a href="https://corefork.telegram.org/api/config#giveaway-countries-max">giveaway_countries_max</a> countries, specified as two-letter ISO 3166-1 alpha-2 country codes.
    ///</summary>
    public TVector<string>? CountriesIso2 { get; set; }

    ///<summary>
    /// Can contain a textual description of additional giveaway prizes.
    ///</summary>
    public string? PrizeDescription { get; set; }

    ///<summary>
    /// Random ID to avoid resending the giveaway
    ///</summary>
    public long RandomId { get; set; }

    ///<summary>
    /// The end date of the giveaway, must be at most <a href="https://corefork.telegram.org/api/config#giveaway-period-max">giveaway_period_max</a> seconds in the future; see <a href="https://corefork.telegram.org/api/giveaways">here »</a> for more info on giveaways.
    ///</summary>
    public int UntilDate { get; set; }

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
        if (OnlyNewSubscribers) { Flags[0] = true; }
        if (WinnersAreVisible) { Flags[3] = true; }
        if (AdditionalPeers?.Count > 0) { Flags[1] = true; }
        if (CountriesIso2?.Count > 0) { Flags[2] = true; }
        if (PrizeDescription != null) { Flags[4] = true; }

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(BoostPeer);
        if (Flags[1]) { writer.Write(AdditionalPeers); }
        if (Flags[2]) { writer.Write(CountriesIso2); }
        if (Flags[4]) { writer.Write(PrizeDescription); }
        writer.Write(RandomId);
        writer.Write(UntilDate);
        writer.Write(Currency);
        writer.Write(Amount);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        if (Flags[0]) { OnlyNewSubscribers = true; }
        if (Flags[3]) { WinnersAreVisible = true; }
        BoostPeer = reader.Read<MyTelegram.Schema.IInputPeer>();
        if (Flags[1]) { AdditionalPeers = reader.Read<TVector<MyTelegram.Schema.IInputPeer>>(); }
        if (Flags[2]) { CountriesIso2 = reader.Read<TVector<string>>(); }
        if (Flags[4]) { PrizeDescription = reader.ReadString(); }
        RandomId = reader.ReadInt64();
        UntilDate = reader.ReadInt32();
        Currency = reader.ReadString();
        Amount = reader.ReadInt64();
    }
}