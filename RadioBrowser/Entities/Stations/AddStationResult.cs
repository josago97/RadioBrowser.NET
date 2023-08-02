using System;

namespace RadioBrowser
{
    public class AddStationResult : ActionResult
    {
        /// <summary>
        /// New station uuid.
        /// </summary>
        public Guid Uuid { get; set; }
    }
}
