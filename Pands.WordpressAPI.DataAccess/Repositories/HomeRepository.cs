using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using Pands.WordpressAPI.DataAccess.Clients;
using Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress;

namespace Pands.WordpressAPI.DataAccess.Repositories
{
    public class HomeRepository : IRepository<String>
    {
        private readonly IWordpressClient _wordpressClient;

        public HomeRepository(IWordpressClient wordpressClient)
        {
            this._wordpressClient = wordpressClient;
        }

        public IQueryable<string> List()
        {
            var allUsers = _wordpressClient.List<UserFilter, User>(_wordpressClient.proxy.GetUsers, null);
            var singleUser = _wordpressClient.Get<int, User>(_wordpressClient.proxy.GetUser, 13261518);
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
    }
}
