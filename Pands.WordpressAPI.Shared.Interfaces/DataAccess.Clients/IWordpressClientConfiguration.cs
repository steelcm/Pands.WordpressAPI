using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients
{
    public interface IWordpressClientConfiguration
    {
        int BlogId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string BaseUrl { get; set; }
        string FullUrl { get; }
    }
}
