using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pands.WordpressAPI.Shared.Interfaces.DataAccess.Clients
{
    public interface IWordpressClient
    {
        IWordpressClientConfiguration configuration { get; }
        IWordpressProxy proxy { get; }

        TResult Get<T1, TResult>(Func<int, string, string, T1, TResult> route, T1 arg);

        IEnumerable<TResult> List<T1, TResult>(Func<int, string, string, T1, IEnumerable<TResult>> route, T1 arg);
    }
}
