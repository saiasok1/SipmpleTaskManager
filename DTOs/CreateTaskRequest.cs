namespace SimpleTaskManager.DTOs;

public class CreateTaskRequest
{
    public string Title { get; set; } = String.Empty;
    public bool IsCompleted { get; set; }
}