using CookComputing.XmlRpc;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.DataAccess.Clients
{
    public class WordpressClient : IWordpressClient
    {
        public IWordpressClientConfiguration configuration { get; protected set; }
        public IWordpressProxy proxy { get; protected set; }

        public WordpressClient(IWordpressClientConfiguration wordpressConfiguration)
        {
            configuration = wordpressConfiguration;
            proxy = (IWordpressProxy)XmlRpcProxyGen.Create(typeof(IWordpressProxy));
            proxy.Url = configuration.FullUrl;
        }

        public TResult Get<T1, TResult>(Func<int, string, string, T1, TResult> route, T1 arg)
        {
            var result = route(configuration.BlogId, configuration.Username, configuration.Password, arg);
            return result;
        }

        public IEnumerable<TResult> List<T1, TResult>(Func<int, string, string, T1, IEnumerable<TResult>> route, T1 arg)
        {
            var results = route(configuration.BlogId, configuration.Username, configuration.Password, arg);
            return results;
        }
    }
}
