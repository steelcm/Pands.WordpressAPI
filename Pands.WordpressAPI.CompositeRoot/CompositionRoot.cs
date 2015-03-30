using Pands.WordpressAPI.DataAccess.Clients;
using Pands.WordpressAPI.DataAccess.Repositories;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Repositories;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress;

namespace Pands.WordpressAPI.CompositeRoot
{
    public class CompositionRoot : Registry
    {
        public CompositionRoot()
        {
            // Repositories
            For<IRepository<String>>().Use<HomeRepository>();
            For<IRepository<User>>().Use<UserRepository>();
            For<IRepository<Post>>().Use<PostRepository>();

            // Data Access
            For<IWordpressClient>().Use<WordpressClient>();
            For<IWordpressClientConfiguration>().Use<WordpressClientConfiguration>()
                .Ctor<int>("blogid").Is(1)
                .Ctor<string>("username").Is("steelcm")
                .Ctor<string>("password").Is("")
                .Ctor<string>("baseurl").Is("https://steelcm.wordpress.com")
                ;
        }
    }
}
