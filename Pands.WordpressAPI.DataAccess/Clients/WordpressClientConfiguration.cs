using CookComputing.XmlRpc;
using Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.DataAccess.Clients
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class WordpressClientConfiguration : IWordpressClientConfiguration
    {
        public WordpressClientConfiguration(int blogid, string username, string password, string baseurl)
        {
            this.BlogId = blogid;
            this.Username = username;
            this.Password = password;
            this.BaseUrl = baseurl;
        }

        [XmlRpcMember("blog_id")]
        public int BlogId { get; set; }

        [XmlRpcMember("username")]
        public string Username { get; set; }

        [XmlRpcMember("password")]
        public string Password { get; set; }

        public string BaseUrl { get; set; }

        public string FullUrl { get { return string.Concat(BaseUrl, BaseUrl.EndsWith("/") ? "xmlrpc.php" : "/xmlrpc.php"); } }
    }
}
