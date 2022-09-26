using ES_CQRS.Seedwork;

namespace ES_CQRS.Infrastructure;

public class MediatRCommandDispatcher : ICommandDispatcher
{
    public MediatRCommandDispatcher()
    {
        
    }
    public Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}