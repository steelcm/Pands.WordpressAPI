using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressSharp.Models;

namespace Pands.WordpressAPI.DataAccess.Repositories
{
    public class PostRepository : IRepository<Post>
    {
        private readonly IWordpressClient _wordpressClient;

        public PostRepository(IWordpressClient wordpressClient)
        {
            this._wordpressClient = wordpressClient;
        }

        public IQueryable<Post> List()
        {
            var allUsers = _wordpressClient.List<PostFilter, Post>(_wordpressClient.proxy.GetPosts, null);
            return allUsers.AsQueryable();
        }

        public Post Get(Func<Post, bool> where)
        {
            if (!this.List().Any(where))
                throw new ArgumentException("Unable to find any entities");
            return this.List().First(where);
        }

        public IQueryable<Post> Query(Func<Post, bool> where)
        {
            if (!this.List().Any(where))
                throw new ArgumentException("Unable to find any entities");
            return this.List().Where(where).AsQueryable();
        }
    }
}
