namespace ES_CQRS.Seedwork;

public interface IQueryHandler<in TQuery> where TQuery : class,IQuery
{
    Task HandelAsync(TQuery query, CancellationToken cancellationToken = default);
}