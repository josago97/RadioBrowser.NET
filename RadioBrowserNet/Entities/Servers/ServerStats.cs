using System.Text.Json.Serialization;

namespace RadioBrowserNet.Entities.Servers
{
    public class ServerStats
    {
        [JsonPropertyName("supported_version")]
        public int SupportedVersion { get; set; }

        [JsonPropertyName("software_version")]
        public string SoftwareVersion { get; set; }

        public string Status { get; set; }

        public int Stations { get; set; }

        [JsonPropertyName("stations_broken")]
        public int StationsBroken { get; set; }

        public int Tags { get; set; }

        [JsonPropertyName("clicks_last_hour")]
        public int ClicksLastHour { get; set; }

        [JsonPropertyName("clicks_last_day")]
        public int ClicksLastDay { get; set; }

        public int Languages { get; set; }

        public int Countries { get; set; }
    }
}
