﻿// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/channels.SponsoredMessageReportResult" />
///</summary>
[JsonDerivedType(typeof(TSponsoredMessageReportResultChooseOption), nameof(TSponsoredMessageReportResultChooseOption))]
[JsonDerivedType(typeof(TSponsoredMessageReportResultAdsHidden), nameof(TSponsoredMessageReportResultAdsHidden))]
[JsonDerivedType(typeof(TSponsoredMessageReportResultReported), nameof(TSponsoredMessageReportResultReported))]
public interface ISponsoredMessageReportResult : IObject
{

}
