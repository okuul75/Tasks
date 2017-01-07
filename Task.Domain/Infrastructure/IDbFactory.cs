using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Concrete;

namespace Task.Domain.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TaskDbContext Init();
    }
}
