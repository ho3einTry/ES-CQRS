

using ES_CQRS.Seedwork;

namespace ES_CQRS;

public class DeleteCourseCommand : ICommand
{
    public DeleteCourseCommand()
    {
        
    }

    public DeleteCourseCommand(int id)
    {
        Id = id;
    }
    public int Id { get; set; }
}