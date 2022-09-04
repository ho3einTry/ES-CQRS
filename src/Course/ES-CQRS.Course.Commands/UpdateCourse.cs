namespace ES_CQRS;

public class UpdateCourse : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}