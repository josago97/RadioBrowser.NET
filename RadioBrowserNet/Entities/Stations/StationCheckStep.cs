using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using RadioBrowserNet.Utilities.JsonConverters;

namespace RadioBrowserNet.Entities.Stations
{
    public class StationCheckStep
    {
        /// <summary>
        /// An unique id for this StationCheckStep.
        /// </summary>
        public Guid StepUuid { get; set; }

        /// <summary>
        /// An unique id for this StationCheckStep.
        /// </summary>
        [JsonPropertyName("parent_stepuuid")]
        public Guid? ParentStepUuid { get; set; }

        /// <summary>
        /// An unique id for referencing a StationCheck.
        /// </summary>
        public Guid? CheckUuid { get; set; }

        /// <summary>
        /// An unique id for referencing a Station.
        /// </summary>
        public Guid StationUuid { get; set; }

        /// <summary>
        /// The url that this step of the checking process handled.
        /// </summary>
        [JsonConverter(typeof(UriConverter))]
        public Uri Url { get; set; }

       
        
        
        /// <summary>
        /// The url that this step of the checking process handled.
        /// </summary>
        [JsonConverter(typeof(UriConverter))]
        public Uri UrlType { get; set; }





        /// <summary>
        /// 
        /// </summary>
        public string? Error { get; set; }

        /// <summary>
        /// Date and time of step creation.
        /// </summary>
        [JsonPropertyName("creation_iso8601")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Codec { get; set; }
    }
}
