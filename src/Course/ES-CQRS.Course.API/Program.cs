using ES;
using ES_CQRS;
using ES_CQRS.Course.API;
using ES_CQRS.Course.Queries;
using ES_CQRS.Seedwork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDI();

var app = builder.Build();


//app.MapGet("/course", GetAllCourse);
//app.MapGet("/course/{id}", GetCourse);
app.MapPost("/course", AddCourse);
app.MapPut("/course", UpdateCourse);
app.MapDelete("/course/{id}", DeleteCourse);



app.Run();

//
// async Task<IResult> GetAllCourse(IQueryDispatcher dispatcher, CancellationToken token)
// {
//     var courses = await dispatcher.QueryAsync<IReadOnlySet<Course>>(new GetAllCourseQuery(), token);
//     return courses.Any() ? Results.Ok(courses) : Results.NotFound();
// }
// async Task<IResult> GetCourse(IQueryDispatcher dispatcher, CancellationToken token, int id)
// {
//     var course = await dispatcher.QueryAsync<Course?>(new GetCourseQuery(), token);
//     return course is not null ? Results.Ok(course) : Results.NotFound();
// }
async Task<IResult> AddCourse(ICommandDispatcher dispatcher, CancellationToken token, AddCourseCommand command)
{
    await dispatcher.SendAsync(command, token);
    return Results.Ok();
}
async Task<IResult> UpdateCourse(ICommandDispatcher dispatcher, CancellationToken token, UpdateCourseCommand command)
{
    await dispatcher.SendAsync(command, token);
    return Results.Ok();
}
async Task<IResult> DeleteCourse(ICommandDispatcher dispatcher, CancellationToken token, int id)
{
    var command = new DeleteCourseCommand(id);
    await dispatcher.SendAsync(command, token);
    return Results.Ok();
}