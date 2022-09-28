using ES_CQRS.Seedwork;

namespace ES_CQRS.Infrastructure;

public class RedisCommandDispatcher:ICommandDispatcher
{
    public Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default) where TCommand : class, ICommand
    {
        throw new NotImplementedException();
    }
}