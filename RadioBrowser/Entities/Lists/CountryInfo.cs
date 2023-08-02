using System.Text.Json.Serialization;

namespace RadioBrowser
{
    public class CountryInfo
    {
        /// <summary>
        /// Country name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Country code.
        /// </summary>
        [JsonPropertyName("iso_3166_1")]
        public string Code { get; set; }

        /// <summary>
        /// Count of stations in country.
        /// </summary>
        public uint StationCount { get; set; }
    }
}
