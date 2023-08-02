using System.Text.Json.Serialization;

namespace RadioBrowser
{
    public class LanguageInfo
    {
        /// <summary>
        /// Language name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Language code.
        /// </summary>
        [JsonPropertyName("iso_639")]
        public string Code { get; set; }

        /// <summary>
        /// Count of stations with language.
        /// </summary>
        public uint StationCount { get; set; }
    }
}
