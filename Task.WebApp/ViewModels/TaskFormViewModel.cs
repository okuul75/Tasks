using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.WebApp.ViewModels
{
    public class TaskFormViewModel
    {
        //public HttpPostedFileBase File { get; set; }

        public string TaskDescription { get; set; }

        public string TaskCreatingDate { get; set; }

        public string TaskRealizationDate { get; set; }

        public string TaskRealizationState { get; set; }
    }
}