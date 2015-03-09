using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pands.WordpressAPI.API.Controllers
{
    public class HomeController : ApiController
    {
        private readonly IRepository<String> _homeRepository;

        public HomeController(IRepository<String> homeRepository)
        {
            _homeRepository = homeRepository;
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return _homeRepository.List();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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