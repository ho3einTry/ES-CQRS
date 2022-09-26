namespace ES_CQRS.Seedwork;

public interface ICommandHandler<in TCommand> where
    TCommand : class, ICommand
{
    Task HandelAsync(TCommand command, CancellationToken cancellationToken = default);
}