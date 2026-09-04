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
}