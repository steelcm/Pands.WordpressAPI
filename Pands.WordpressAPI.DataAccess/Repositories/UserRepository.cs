using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress;

namespace Pands.WordpressAPI.DataAccess.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly IWordpressClient _wordpressClient;

        public UserRepository(IWordpressClient wordpressClient)
        {
            this._wordpressClient = wordpressClient;
        }

        public IQueryable<User> List()
        {
            var allUsers = _wordpressClient.List<UserFilter, User>(_wordpressClient.proxy.GetUsers, null);
            return allUsers.AsQueryable();
        }

        public User Get(Func<User, bool> where)
        {
            if (!this.List().Any(where))
                throw new ArgumentException("Unable to find any entities");
            return this.List().First(where);
        }

        public IQueryable<User> Query(Func<User, bool> where)
        {
            if (!this.List().Any(where))
                throw new ArgumentException("Unable to find any entities");
            return this.List().Where(where).AsQueryable();
        }
    }
}
