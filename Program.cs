using SimpleTaskManager.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();

var app = builder.Build();

// // Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();
var tasks = new List<TaskItem>
{
    new TaskItem
    {
        Id = 1,
        Title = "Learn C#",
        IsCompleted = true
    },

    new TaskItem
    {
    Id = 2,
    Title = "Learn .NET",
    IsCompleted = false
    },

    new TaskItem
    {
        Id = 3,
        Title = "Build my first API",
        IsCompleted = false
    }
};

    
app.MapGet("/tasks", () =>
{
    return tasks;
});

app.MapGet("/tasks/{id}", (int id) =>
{
    var task = tasks.Find(task => task.Id == id);

    if (task == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(task);
});




app.Run();

