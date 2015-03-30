using System.Dynamic;
using CookComputing.XmlRpc;

namespace Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress
{
    [XmlRpcMissingMapping(MappingAction.Ignore)]
    public class MediaItemMetadata
    {
        [XmlRpcMember("width")]
        public int Width { get; set; }

        [XmlRpcMember("height")]
        public int Height { get; set; }

        [XmlRpcMember("file")]
        public string File { get; set; }

        [XmlRpcMember("sizes")]
        public MediaItemSizes Sizes { get; set; }
    }
}
