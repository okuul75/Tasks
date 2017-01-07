using Task.Domain.Entities;
using Task.Domain.Infrastructure;

namespace Task.Domain.Repositories
{
    public interface ITaskRepository : IRepository<TaskToDo>
    {
        TaskToDo GetTaskById(int taskId);

        TaskToDo GetTaskByState(string currentState);
    }
}