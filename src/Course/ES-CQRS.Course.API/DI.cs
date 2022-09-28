using System.Numerics;
using ES_CQRS.Infrastructure;
using ES_CQRS.Seedwork;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ES_CQRS.Course.API;

public static class DI
{
    public static void AddDI(this IServiceCollection services)
    {
        services.AddCommandDispatcher();
    }
}