namespace Pands.WordpressAPI.Shared.Models.DataAccess.Wordpress
{
    public abstract class FilterBase
    {
        public int Number { get; set; }
        protected FilterBase()
        {
            Number = int.MaxValue;
        }
    }
}
