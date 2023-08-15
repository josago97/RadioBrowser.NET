namespace RadioBrowserNet
{
    public class QueryOptions
    {
        /// <summary>
        /// Do not count broken stations
        /// </summary>
        public bool? HideBroken { get; set; }

        /// <summary>
        /// Starting value of the result list from the database.
        /// For example, if you want to do paging on the server side.
        /// </summary>
        public uint? Offset { get; set; }
    }
}
