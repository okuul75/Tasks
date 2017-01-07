using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Task.Domain.Entities
{
    public class TaskToDo
    {
        [Key]
        public int TaskId { get; set; }

        public DateTime CreatingDate { get; set; }

        public DateTime RealizationDate { get; set; }

        public bool RealizationState { get; set; }

        public string Description { get; set; }

        public TaskToDo()
        {
            CreatingDate = DateTime.Now;
        }
    }
}
