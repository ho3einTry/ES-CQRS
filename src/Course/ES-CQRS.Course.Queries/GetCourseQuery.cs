using ES_CQRS.Seedwork;

namespace ES_CQRS.Course.Queries;

public class GetCourseQuery : IQuery,IQuery<ES.Course?>
{
    public int Id { get; set; }
    
}