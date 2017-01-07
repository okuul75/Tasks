using System.Data.Entity;
using System.Diagnostics;
using Task.Domain.Entities;
using Task.Domain.Repositories;

namespace Task.Domain.Concrete
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext() : base("TaskDbContext")
        {
            Database.Log = s => Debug.WriteLine(s);
        }

        public DbSet<TaskToDo> TasksToDo { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TaskConfiguration());
        }
    }
}

