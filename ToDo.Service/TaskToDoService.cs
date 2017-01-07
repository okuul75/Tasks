using System.Collections.Generic;
using System.Linq;
using Task.Domain.Entities;
using Task.Domain.Infrastructure;
using Task.Domain.Repositories;

namespace ToDo.Service
{
    public class TaskToDoService : ITaskToDoService
    {
        private readonly ITaskRepository _tasksRepository;
        private readonly IUnitOfWork _unitOfWork;

        public TaskToDoService(ITaskRepository tasksRepository, IUnitOfWork unitOfWork)
        {
            _tasksRepository = tasksRepository;
            _unitOfWork = unitOfWork;
        }

        #region ITaskToDoService Members

        public IEnumerable<TaskToDo> GetTasks()
        {
            var tasks = _tasksRepository.GetAll();
            return tasks;
        }

        public IEnumerable<TaskToDo> GetTasksByState(string currentState = null)
        {
            if(string.IsNullOrEmpty(currentState))
            {
                return _tasksRepository.GetAll();
            }
            else
            {
                return _tasksRepository.GetAll().Where(s => s.RealizationState.ToString() == currentState);
            }
        }

        public TaskToDo GetTask(int id)
        {
            var task = _tasksRepository.GetById(id);
            return task;
        }

        public void CreateTask(TaskToDo task)
        {
            _tasksRepository.Add(task);
        }

        public void SaveTask()
        {
            _unitOfWork.Commit();
        }

        #endregion
    }
}