using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Entities;
using Task.Domain.Infrastructure;

namespace Task.Domain.Repositories
{
    public class TaskRepository : RepositoryBase<TaskToDo>, ITaskRepository
    {
        public TaskRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public TaskToDo GetTaskById(int taskId)
        {
            var task = DbContext.TasksToDo.FirstOrDefault(t => t.TaskId == taskId);
            return task;
        }

        public TaskToDo GetTaskByState(string currentState)
        {
            var state = DbContext.TasksToDo.Where(s => s.RealizationState.ToString() == currentState).FirstOrDefault();

            return state;
        }
    }
}
