using SimpleTaskManager.Models;

namespace SimpleTaskManager.Services;

public class TaskServices
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

    public List<TaskItem> GetAll()
    {
        return tasks;
    }

    public TaskItem? GetById(int id)
    {
        return tasks.Find(task => task.Id == id);
    }

    public TaskItem Create(TaskItem task)
    {
        task.Id = tasks.Count + 1;
        tasks.Add(task);
        return task;
    }

    public bool Update(int id, TaskItem updatedTask)
    {
        var task = GetById(id);
        if (task == null)
        {
            return false;
        }

        task.Title = updatedTask.Title;
        task.IsCompleted = updatedTask.IsCompleted;
        return true;   
    }

    public bool Delete(int id)
    {
        var task = GetById(id);
        if (task == null)
        {
            return false;
        }  
        tasks.Remove(task);
        return true;
    }
}