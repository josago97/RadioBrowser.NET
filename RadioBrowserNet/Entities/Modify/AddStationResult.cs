using System;

namespace RadioBrowserNet.Entities.Modify
{
    public class AddStationResult : ActionResult
    {
        /// <summary>
        /// New station uuid.
        /// </summary>
        public Guid Uuid { get; set; }
    }
}
