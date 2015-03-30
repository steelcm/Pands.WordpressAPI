using CookComputing.XmlRpc;
using Pands.WordpressAPI.DataAccess.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.DataAccess.Services
{
    public class WordpressService
    {
        public IWordpressProxy WordpressProxy { get; internal set; }

        public WordpressService()
        {
            this.WordpressProxy = (IWordpressProxy)XmlRpcProxyGen.Create(typeof(IWordpressProxy));
        }
    }
}
