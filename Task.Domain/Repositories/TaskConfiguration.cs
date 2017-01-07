using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Entities;

namespace Task.Domain.Repositories
{
    public class TaskConfiguration : EntityTypeConfiguration<TaskToDo>
    {
        public TaskConfiguration()
        {
            ToTable("Tasks");
            Property(t => t.TaskId).IsRequired();
            Property(t => t.Description).IsRequired();
            Property(t => t.CreatingDate).IsRequired();
            Property(t => t.RealizationDate).IsRequired();
            Property(t => t.RealizationState).IsRequired();

        }
    }
}
