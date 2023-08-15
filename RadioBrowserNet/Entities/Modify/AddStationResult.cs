using System;

namespace RadioBrowserNet
{
    public class AddStationResult : ActionResult
    {
        /// <summary>
        /// New station uuid.
        /// </summary>
        public Guid Uuid { get; set; }
    }
}
