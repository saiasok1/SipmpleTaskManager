using SimpleTaskManager.Models;
using SimpleTaskManager.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddSingleton<ITaskService, TaskService>();


var app = builder.Build();
app.MapControllers();
app.Run();

