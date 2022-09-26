using ES_CQRS.Seedwork;

namespace ES_CQRS.Course.Queries;

public class GetAllCourseQuery : IQuery,IQuery<IReadOnlySet<ES.Course>>
{
    public GetAllCourseQuery()
    {
        
    }
}