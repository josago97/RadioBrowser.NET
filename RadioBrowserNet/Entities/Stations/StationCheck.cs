using System;
using System.Text.Json.Serialization;
using RadioBrowserNet.Utilities.JsonConverters;

namespace RadioBrowserNet.Entities.Stations
{
    public class StationCheck
    {
        /// <summary>
        /// An unique id for this StationCheck.
        /// </summary>
        public Guid CheckUuid { get; set; }

        /// <summary>
        /// An unique id for referencing a Station.
        /// </summary>
        public Guid StationUuid { get; set; }

        /// <summary>
        /// DNS Name of the server that did the stream check.
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// High level name of the used codec of the stream. 
        /// May have the format AUDIO or AUDIO/VIDEO.
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Bitrate 1000 bits per second (kBit/s) of the stream. (Audio + Video)
        /// </summary>
        public int Bitrate { get; set; }

        /// <summary>
        /// Mark if this stream is using HLS distribution or non-HLS.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool Hls { get; set; }

        /// <summary>
        /// Mark if this stream is reachable or not.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool Ok { get; set; }

        /// <summary>
        /// Date and time of check creation.
        /// </summary>
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Direct stream url that has been resolved from the main stream url. 
        /// HTTP redirects and playlists have been decoded. 
        /// If Hls is <see langword="true" /> then this is still a HLS-playlist.
        /// </summary>
        [JsonConverter(typeof(UriConverter))]
        public Uri UrlCache { get; set; }

        /// <summary>
        /// <see langword="true" /> means this stream has provided extended information and it should be used to override the local database, otherwise <see langword="false" />.
        [JsonPropertyName("metainfo_overrides_database")]
        [JsonConverter(typeof(BoolConverter))]
        public bool MetainfoOverridesDatabase { get; set; }

        /// <summary>
        /// <see langword="true" /> that this stream appears in the public shoutcast/icecast directory, otherwise <see langword="false" />.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? Public { get; set; }

        /// <summary>
        /// The name extracted from the stream header.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// The description extracted from the stream header.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Komma separated list of tags. (genres of this stream).
        /// </summary>
        [JsonConverter(typeof(ArrayConverter))]
        public string[]? Tags { get; set; }

        /// <summary>
        /// Official countrycodes as in ISO 3166-1 alpha-2.
        /// </summary>
        public string? CountryCode { get; set; }

        /// <summary>
        /// Official country subdivision codes as in ISO 3166-2
        /// </summary>
        public string? CountrySubdivisionCode { get; set; }

        /// <summary>
        /// The homepage extracted from the stream header.
        /// </summary>
        [JsonConverter(typeof(UriConverter))]
        public Uri? Homepage { get; set; }

        /// <summary>
        /// The favicon extracted from the stream header.
        /// </summary>
        [JsonConverter(typeof(UriConverter))]
        public Uri? Favicon { get; set; }

        /// <summary>
        /// The loadbalancer extracted from the stream header.
        /// </summary>
        public string? Loadbalancer { get; set; }

        /// <summary>
        /// The name of the server software used.
        /// </summary>
        [JsonPropertyName("server_software")]
        public string? ServerSoftware { get; set; }

        /// <summary>
        /// Audio sampling frequency in Hz.
        /// </summary>
        public uint? Sampling { get; set; }

        /// <summary>
        /// Timespan in miliseconds this check needed to be finished.
        /// </summary>
        [JsonPropertyName("timing_ms")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan Timing { get; set; }



        /// <summary>
        /// sdfsdfsz.
        /// </summary>
        public string? LanguageCodes { get; set; }



        /// <summary>
        /// <see langword="true" /> means that a ssl error occured while connecting to the stream, <see langword="false" /> otherwise.
        /// </summary>
        [JsonPropertyName("ssl_error")]
        [JsonConverter(typeof(BoolConverter))]
        public bool SslError { get; set; }

        /// <summary>
        /// Latitude on earth where the stream is located.
        /// </summary>
        [JsonPropertyName("geo_lat")]
        public double? GeoLatitude { get; set; }

        /// <summary>
        /// Longitude on earth where the stream is located.
        /// </summary>
        [JsonPropertyName("geo_long")]
        public double? GeoLongitude { get; set; }
    }
}
