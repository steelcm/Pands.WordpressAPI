using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> List();
        T Get(Func<T, bool> where);
        IQueryable<T> Query(Func<T, bool> where);
    }
}
