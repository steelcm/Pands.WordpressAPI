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
    public class HomeController : ApiController
    {
        private readonly IRepository<User> _userRepository;

        public HomeController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/<controller>
        public IEnumerable<User> Get()
        {
            return _userRepository.List();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return _userRepository.Get(o => o.Id.Equals(id.ToString())).DisplayName;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}