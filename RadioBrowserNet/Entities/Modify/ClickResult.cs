using System;
using System.Text.Json.Serialization;

namespace RadioBrowserNet
{
    public class ClickResult : ActionResult
    {
        /// <summary>
        /// Station uuid
        /// </summary>
        public Guid StationUuid { get; set; }

        /// <summary>
        /// Station name
        /// </summary>
        [JsonPropertyName("name")]
        public string StationName { get; set; }

        /// <summary>
        /// Station url
        /// </summary>
        [JsonPropertyName("url")]
        public Uri StationUrl { get; set; }
    }
}
