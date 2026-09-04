using Microsoft.AspNetCore.Mvc;
using SimpleTaskManager.Models;
using SimpleTaskManager.Services;

namespace SimpleTaskManager.Controllers;

[ApiController]
[Route("tasks")]

public class TaskController : ControllerBase
{
    private readonly ITaskService taskservices;

    public TaskController(ITaskService taskservices)
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

    //GET by id action
    // GET /tasks/{id}
    [HttpGet("{id}")]
    public IActionResult GetTask(int id)
    {
        var task = taskservices.GetById(id);
        if (task == null)
        {
            return NotFound();
        }

        return Ok(task);
    }

    //POST action
    //POST /tasks
    [HttpPost]
    public IActionResult CreateTask(TaskItem task)
    {
        var createdTask = taskservices.Create(task);
        return Created($"/tasks/{createdTask.Id}", createdTask);
    }

    //PUT action
    //PUT /tasks/{id}
    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, TaskItem updatedTask)
    {
        var isUpdated = taskservices.Update(id, updatedTask);
        if (!isUpdated)
        {
            return NotFound();
        }

        return Ok(taskservices.GetById(id));
    }

    //DELETE action
    //DELETE /tasks/{id}
    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        var deleted = taskservices.Delete(id);
        if (!deleted)
        {
            return NotFound();
        }
        return NoContent();
    }
}

