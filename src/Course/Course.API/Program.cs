var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/course", GetAllCourse);
app.MapGet("/course/{id}",GetCourse);
app.MapPost("/course", AddCourse);
app.MapPut("/course", UpdateCourse);
app.MapDelete("/course", DeleteCourse);

app.Run();


//async Task GetAllCourse() =>
