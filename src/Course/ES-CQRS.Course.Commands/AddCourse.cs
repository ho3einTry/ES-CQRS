namespace ES_CQRS;

public class AddCourse : ICommand
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
}