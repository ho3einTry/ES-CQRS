namespace ES_CQRS;

public class DeleteCourse : ICommand
{
    public int Id { get; set; }
}