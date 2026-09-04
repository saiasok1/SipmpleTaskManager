using SimpleTaskManager.Models;

namespace SimpleTaskManager.Services;

public interface ITaskService
{
    List<TaskItem> GetAll();
    TaskItem? GetById(int id);
    TaskItem Create(TaskItem task);
    bool Update(int id, TaskItem updatedTask);
    bool Delete(int id);
}