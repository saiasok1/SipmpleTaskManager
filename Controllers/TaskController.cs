using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Models;

namespace SimpleTaskManager.Controllers;

[ApiController]
[Route("tasks")]

public class TaskController : ControllerBase
{
    private readonly List<TaskItem> tasks = new()
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

    //GET Action 
    //GET /tasks
    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok(tasks);
    }
}
