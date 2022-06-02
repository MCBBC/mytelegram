using MyTelegram.Handlers.Account;
using MyTelegram.Schema.Account;

namespace MyTelegram.MessengerServer.Handlers.Impl.Account;

public class GetAuthorizationsHandler : RpcResultObjectHandler<RequestGetAuthorizations, IAuthorizations>,
    IGetAuthorizationsHandler, IProcessedHandler
{
    private readonly IQueryProcessor _queryProcessor;
    private readonly ITlAuthorizationConverter _authorizationConverter;

    public GetAuthorizationsHandler(IQueryProcessor queryProcessor,
        ITlAuthorizationConverter authorizationConverter)
    {
        _queryProcessor = queryProcessor;
        _authorizationConverter = authorizationConverter;
    }

    protected override async Task<IAuthorizations> HandleCoreAsync(IRequestInput input,
        RequestGetAuthorizations obj)
    {
        var deviceReadModelList = await _queryProcessor
            .ProcessAsync(new GetDeviceByUidQuery(input.UserId), CancellationToken.None).ConfigureAwait(false);
        var r = _authorizationConverter.ToAuthorizations(deviceReadModelList, input.PermAuthKeyId);
        return new TAuthorizations { Authorizations = new TVector<IAuthorization>(r) };
    }
}
