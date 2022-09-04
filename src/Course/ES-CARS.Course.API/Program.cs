using ES;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/course", GetAllCourse);
app.MapGet("/course/{id}",GetCourse);
app.MapPost("/course", AddCourse);
app.MapPut("/course", UpdateCourse);
app.MapDelete("/course/{id}", DeleteCourse);

app.Run();


async Task GetAllCourse() => Console.WriteLine();
async Task GetCourse(int id) => Console.WriteLine();
async Task AddCourse(Course course) => Console.WriteLine();
async Task UpdateCourse(Course course) => Console.WriteLine();
async Task DeleteCourse(int id) => Console.WriteLine();

