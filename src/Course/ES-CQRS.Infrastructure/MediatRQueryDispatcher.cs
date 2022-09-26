using ES_CQRS.Seedwork;

namespace ES_CQRS.Infrastructure;

public class MediatRQueryDispatcher:IQueryDispatcher
{
    public MediatRQueryDispatcher()
    {
        
    }
    public Task<TResult> QueryAsync<TResult>(IQuery<TResult> query, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<TResult> QueryAsync<TQuery, TResult>(TQuery query, CancellationToken cancellationToken = default) where TQuery : class, IQuery<TResult>
    {
        throw new NotImplementedException();
    }
}