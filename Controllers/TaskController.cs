using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Models;

namespace SimpleTaskManager.Controllers;

[ApiController]
[Route("tasks")]

public class TaskController : ControllerBase
{
    [HttpGet]
    public IActionResult GetTasks()
    {
        return Ok();
    }
}
