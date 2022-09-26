using ES_CQRS.Seedwork;

namespace ES_CQRS.Course.Queries;

public class GetCourseQuery : IQuery
{
    public int Id { get; set; }
    
}