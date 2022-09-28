


using ES_CQRS.Seedwork;

namespace ES_CQRS;

public class AddCourseCommand : ICommand
{
    public string Name { get; set; }
    public string Code { get; set; }
}