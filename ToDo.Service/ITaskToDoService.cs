using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Entities;
using Task.Domain.Repositories;

namespace ToDo.Service
{
    public interface ITaskToDoService
    {
        IEnumerable<TaskToDo> GetTasksByState(string currentState);

        TaskToDo GetTask(int id);

        void CreateTask(TaskToDo task);

        void SaveTask();
    }
}


