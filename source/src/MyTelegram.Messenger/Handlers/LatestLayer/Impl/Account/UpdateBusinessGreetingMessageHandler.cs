﻿// ReSharper disable All

namespace MyTelegram.Handlers.Account;

///<summary>
/// See <a href="https://corefork.telegram.org/method/account.updateBusinessGreetingMessage" />
///</summary>
internal sealed class UpdateBusinessGreetingMessageHandler : RpcResultObjectHandler<MyTelegram.Schema.Account.RequestUpdateBusinessGreetingMessage, IBool>,
    Account.IUpdateBusinessGreetingMessageHandler
{
    protected override Task<IBool> HandleCoreAsync(IRequestInput input,
        MyTelegram.Schema.Account.RequestUpdateBusinessGreetingMessage obj)
    {
        throw new NotImplementedException();
    }
}
