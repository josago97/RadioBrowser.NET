namespace RadioBrowser
{
    public class ExtendedQueryOptions : QueryOptions
    {
        /// <summary>
        /// Name of the attribute the result list will be sorted by
        /// </summary>
        public string Order { get; set; }

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
