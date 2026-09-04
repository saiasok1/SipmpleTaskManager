using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Models;
using SimpleTaskManager.Services;

namespace SimpleTaskManager.Controllers;

[ApiController]
[Route("tasks")]

public class TaskController : ControllerBase
{
    private readonly TaskServices taskservices;

    public TaskController(TaskServices taskservices)
    {
        this.taskservices = taskservices;
    }

    //GET Action 
    //GET /tasks
    [HttpGet]
    public IActionResult GetTasks()
    {
        var tasks = taskservices.GetAll();
        return Ok(tasks);
    }
}

