
using ES_CQRS.Seedwork;

namespace ES_CQRS;

public class UpdateCourseCommand : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}