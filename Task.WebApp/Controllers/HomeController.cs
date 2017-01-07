using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Task.Domain.Entities;
using Task.WebApp.Models;
using Task.WebApp.ViewModels;
using ToDo.Service;

namespace Task.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskToDoService _taskService;
        public int PageSize = 4;

        public HomeController(ITaskToDoService taskService)
        {
            _taskService = taskService;
        }

       // GET: Home
        public ActionResult Index(string currentState = null)
        {
            IEnumerable<TaskToDo> tasks;

            //IEnumerable<MainViewModel> mainViewModelTasks; 
            IEnumerable <TaskViewModel> taskViewModelTasks;

            tasks = _taskService.GetTasksByState(currentState).ToList();

            //mainViewModelTasks = Mapper.Map<IEnumerable<TaskToDo>, IEnumerable<MainViewModel>>(tasks);
            taskViewModelTasks = Mapper.Map<IEnumerable<TaskToDo>,IEnumerable<TaskViewModel>>(tasks);
            


            //return View(mainViewModelTasks);
            return View(taskViewModelTasks);
        }

        [HttpPost]
        public ActionResult Create(TaskFormViewModel newTask)
        {
            if (newTask != null)
            {
                var task = Mapper.Map<TaskFormViewModel, TaskToDo>(newTask);
                _taskService.CreateTask(task);
                _taskService.SaveTask();
            }
           
            return RedirectToAction("Index");
        }

        //public ViewResult TasksList(string state, int page = 1)
        //{
        //    TaskViewModel model = new TaskViewModel
        //    {

        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = page,
        //            ItemsPerPage = PageSize,
        //            TotalItems = state == null ?
        //                    _taskService.GetTasks().Count() :
        //                    _taskService.GetTasks().Where(s => s.RealizationState.ToString() == state).Count()
        //        },
        //        CurrentState = state,
        //        Tasks = _taskService.GetTasks()
        //    };

        //    return View(model);
        //}

    }
}