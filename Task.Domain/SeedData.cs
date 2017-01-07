using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Concrete;
using Task.Domain.Entities;

namespace Task.Domain
{
    public class SeedData : DropCreateDatabaseIfModelChanges<TaskDbContext>
    {
        protected override void Seed(TaskDbContext context)
        {
            GetTasks().ForEach(c => context.TasksToDo.Add(c));

            context.Commit();
        }

        private static List<TaskToDo> GetTasks()
        {
            return new List<TaskToDo>
            {
                new TaskToDo
                {
                    CreatingDate = DateTime.Now,
                    Description = "Ubrać choinkę",
                    RealizationDate = DateTime.Parse("2016-12-22 19:00"),
                    RealizationState = true
                },
                new TaskToDo
                {
                    CreatingDate = DateTime.Now,
                    Description = "Zjeść barszczyk",
                    RealizationDate = DateTime.Parse("2016-12-24 18:00"),
                    RealizationState = true
                },
                new TaskToDo
                {
                    CreatingDate = DateTime.Now,
                    Description = "Prezenty kupić",
                    RealizationDate = DateTime.Parse("2016-12-22 18:00"),
                    RealizationState = true
                },
                new TaskToDo
                {
                    CreatingDate = DateTime.Now,
                    Description = "Sylwester kupić",
                    RealizationDate = DateTime.Parse("2016-12-31 21:00"),
                    RealizationState = false
                },
                new TaskToDo
                {
                    CreatingDate = DateTime.Now,
                    Description = "Narty",
                    RealizationDate = DateTime.Parse("2017-01-06 08:00"),
                    RealizationState = false
                }

            };
        }
    }
}
