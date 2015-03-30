using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress;

namespace Pands.WordpressAPI.API.Controllers
{
    public class PostController : ApiController
    {
        private readonly IRepository<Post> _postRepository;

        public PostController(IRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        // GET api/<controller>
        public IEnumerable<Post> Get()
        {
            return _postRepository.List();
        }

        // GET api/<controller>/5
        public Post Get(int id)
        {
            return _postRepository.Get(o => o.Id.Equals(id.ToString()));
        }
    }
}
