using CookComputing.XmlRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress;

namespace Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients
{
    public interface IWordpressProxy : IXmlRpcProxy
    {
        [XmlRpcMethod("wp.getPost")]
        Post GetPost(int blog_id, string username, string password, int post_id);

        [XmlRpcMethod("wp.getPosts")]
        Post[] GetPosts(int blog_id, string username, string password, PostFilter postFilter);

        [XmlRpcMethod("wp.getUser")]
        User GetUser(int blog_id, string username, string password, int user_id);

        [XmlRpcMethod("wp.getUsers")]
        User[] GetUsers(int blog_id, string username, string password, UserFilter filter);
    }
}
