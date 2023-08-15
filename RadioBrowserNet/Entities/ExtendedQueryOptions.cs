namespace RadioBrowserNet
{
    public abstract class ExtendedQueryOptions : QueryOptions
    {
        /// <summary>
        /// Reverse the result list if set to true
        /// </summary>
        public bool? Reverse { get; set; }

        /// <summary>
        /// Number of returned data rows (items) starting with offset.
        /// </summary>
        public uint? Limit { get; set; }
    }
}
