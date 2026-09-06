namespace SimpleTaskManager.DTOs;

public class UpdateTaskRequest
{
    public string Title { get; set; } = String.Empty;
    public bool IsCompleted { get; set; }
}