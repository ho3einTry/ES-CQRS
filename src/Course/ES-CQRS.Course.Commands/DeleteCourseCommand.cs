

using ES_CQRS.Seedwork;

namespace ES_CQRS;

public class DeleteCourseCommand : ICommand
{
    public int Id { get; set; }
}