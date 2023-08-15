using RadioBrowserNet.Utilities.HttpParsers;

namespace RadioBrowserNet.Entities
{
    public abstract class OrderedQueryOptions<TOrder> : ExtendedQueryOptions where TOrder : struct
    {
        /// <summary>
        /// Name of the attribute the result list will be sorted by
        /// </summary>
        [HttpUrlParam(typeParser: typeof(OrderParser))]
        public TOrder? Order { get; set; }
    }
}
