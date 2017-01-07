using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.WebApp.Models;

namespace Task.WebApp.ViewModels
{
    public class TaskViewModel
    {
        //public int TaskId { get; set; }
        //public string RealizationState { get; set; }
        //public string RealizationDate { get; set; }
        //public string CreatingDate { get; set; }
        //public string Description { get; set; }

        public int TaskId { get; set; }
        public string CurrentState { get; set; }

        public List<MainViewModel> Tasks { get; set; }

        public PagingInfo PagingInfo { get; set; }

    }
}