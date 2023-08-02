namespace RadioBrowser
{
    public class ActionResult
    {
        /// <summary>
        /// True if the request was success, otherwise false.
        /// </summary>
        public bool Ok { get; set; }

        /// <summary>
        /// Request result message.
        /// </summary>
        public string Message { get; set; }
    }
}
