using System.Collections.Generic;

namespace Task.WebApp.ViewModels
{
    public class MainViewModel
    {
        //public List<TaskViewModel> Tasks { get; set; }
        //public int TaskId { get; set; }
        //public string RealizationState { get; set; }
        
        public int TaskId { get; set; }
        public string RealizationState { get; set; }
        public string RealizationDate { get; set; }
        public string CreatingDate { get; set; }
        public string Description { get; set; }

    }
}