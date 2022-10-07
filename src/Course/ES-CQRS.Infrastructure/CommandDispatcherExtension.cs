using System.Reflection;
using ES_CQRS.Handlers;
using ES_CQRS.Seedwork;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ES_CQRS.Infrastructure;

public static class CommandDispatcherExtension
{
    public static void AddCommandDispatcher(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetAssembly(typeof(AddCourseCommandHandler))!);
        services.AddSingleton<ICommandDispatcher,MediatRCommandDispatcher>();
      //  services.AddScoped<typeof(ICommandHandler<Add>)>()
    }
}