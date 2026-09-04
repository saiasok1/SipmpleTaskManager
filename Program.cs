using SimpleTaskManager.Models;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// builder.Services.AddOpenApi();

var app = builder.Build();
app.MapControllers();


// if (app.Environment.IsDevelopment())
// {
//     app.MapOpenApi();
// }

// app.UseHttpsRedirection();


// app.MapGet("/tasks/{id}", (int id) =>
// {
//     var task = tasks.Find(task => task.Id == id);

//     if (task == null)
//     {
//         return Results.NotFound();
//     }

//     return Results.Ok(task);
// });

// app.MapGet("/square/{number}", (int number) =>
// {
//     return Results.Ok(number * number);
    
// });


// app.MapPost("/tasks", (TaskItem task)=>
// {
//     task.Id = tasks.Count + 1;
//     tasks.Add(task);

//     return Results.Created($"/tasks/{task.Id}", task);
// });

// app.MapPut("/tasks/{id}", (int id, TaskItem updatedTask) =>
// {
//     var task = tasks.Find(task => task.Id == id);

//     if (task == null)
//     {
//         return Results.NotFound();
//     }

//     task.Title = updatedTask.Title;
//     task.IsCompleted = updatedTask.IsCompleted;

//     return Results.Ok(task);
// });


// app.MapDelete("/tasks/{id}", (int id) =>
// {
//     var task = tasks.Find(task => task.Id == id);
//     if (task == null)
//     {
//         return Results.NotFound();
//     }

//     tasks.Remove(task);
//     return Results.NoContent();
// });



app.Run();

