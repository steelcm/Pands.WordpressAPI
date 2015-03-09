using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;

namespace Pands.WordpressAPI.DataAccess.Repositories
{
    public class HomeRepository : IRepository<String>
    {
        public IQueryable<string> List()
        {
            return (new string[] { "Chris", "Is", "Awesome!" }).AsQueryable();
        }

        public string Get(Func<string, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<string> Query(Func<string, bool> where)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
