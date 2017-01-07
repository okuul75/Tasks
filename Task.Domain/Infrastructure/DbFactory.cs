using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Concrete;
using Task.Domain.Entities;

namespace Task.Domain.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TaskDbContext _dbContext;
    
        public TaskDbContext Init()
        {
            return _dbContext ?? (_dbContext = new TaskDbContext());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
