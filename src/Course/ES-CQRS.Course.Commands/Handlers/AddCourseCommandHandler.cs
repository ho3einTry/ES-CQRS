using ES_CQRS.Seedwork;

namespace ES_CQRS.Handlers;

public class AddCourseCommandHandler : ICommandHandler<AddCourseCommand>
{
    public AddCourseCommandHandler()
    {
        
    }
    public async Task HandelAsync(AddCourseCommand command, CancellationToken cancellationToken = default)
    {
        Console.WriteLine($"AddCourseCommand");
        await Task.Delay(10);
    }

    public async Task Handle(AddCourseCommand notification, CancellationToken cancellationToken)
    {
        await HandelAsync(notification, cancellationToken);
    }
}