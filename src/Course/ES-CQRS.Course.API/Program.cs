using ES;
using ES_CQRS;
using ES_CQRS.Course.API;
using ES_CQRS.Seedwork;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDI();

var app = builder.Build();

app.MapGet("/c", () => Console.WriteLine());


 app.MapGet("/course", GetAllCourse);
 app.MapGet("/course/{id}", GetCourse);
 app.MapPost("/course", AddCourse);
 app.MapPut("/course", UpdateCourse);
 app.MapDelete("/course/{id}", DeleteCourse);

app.Run();


async Task GetAllCourse(IQueryDispatcher dispatcher) => Console.WriteLine("");

async Task GetCourse(IQueryDispatcher dispatcher, int id) => Console.WriteLine();
async Task AddCourse(ICommandDispatcher dispatcher, AddCourseCommand command) => Console.WriteLine();

async Task UpdateCourse(ICommandDispatcher dispatcher, UpdateCourseCommand command) => Console.WriteLine();

async Task DeleteCourse(ICommandDispatcher dispatcher, int id) => Console.WriteLine();