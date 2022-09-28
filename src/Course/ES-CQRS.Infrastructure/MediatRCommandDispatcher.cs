using ES_CQRS.Seedwork;
using MediatR;

namespace ES_CQRS.Infrastructure;

public class MediatRCommandDispatcher : ICommandDispatcher
{
    private readonly IMediator _mediator;

    public MediatRCommandDispatcher(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task SendAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        await _mediator.Publish(command, cancellationToken);
    }
}