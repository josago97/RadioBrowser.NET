using RadioBrowser.Utilities;

namespace RadioBrowser
{
    public class AdvancedSearchOptions : ExtendedQueryOptions
    {
        /// <summary>
        /// OPTIONAL, name of the station.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// OPTIONAL. True: only exact matches, otherwise all matches.
        /// </summary>
        public bool? NameExact { get; set; }

        /// <summary>
        /// OPTIONAL, country of the station
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// OPTIONAL. True: only exact matches, otherwise all matches.
        /// </summary>
        public bool? CountryExact { get; set; }

        /// <summary>
        /// OPTIONAL, 2-digit countrycode of the station (ISO 3166-1 alpha-2).
        /// </summary>
        public string Countrycode { get; set; }

        /// <summary>
        /// OPTIONAL, state of the station.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// OPTIONAL. True: only exact matches, otherwise all matches.
        /// </summary>
        public bool? StateExact { get; set; }

        /// <summary>
        /// OPTIONAL, language of the station.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// OPTIONAL. True: only exact matches, otherwise all matches.
        /// </summary>
        public string LanguageExact { get; set; }

        /// <summary>
        /// OPTIONAL. True: only exact matches, otherwise all matches.
        /// </summary>
        public bool? TagExact { get; set; }

        /// <summary>
        /// OPTIONAL. , a comma-separated list of tag.
        /// It can also be an array of string in JSON HTTP POST parameters.
        /// All tags in list have to match.
        /// </summary>
        public string TagList { get; set; }

        /// <summary>
        /// OPTIONAL, codec of the station.
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// OPTIONAL, minimum of kbps for bitrate field of stations in result.
        /// </summary>
        public uint? BitrateMin { get; set; }

        /// <summary>
        /// OPTIONAL, maximum of kbps for bitrate field of stations in result.
        /// </summary>
        public uint? BitrateMax { get; set; }

        /// <summary>
        /// OPTIONAL, not set=display all, 
        /// true=show only stations with geolocalization info, 
        /// false=show only stations without geolocalization info.
        /// </summary>
        [HttpUrlParam("has_geo_info")]
        public bool? HasGeoInfo { get; set; }

        /// <summary>
        /// OPTIONAL, not set=display all, 
        /// true=show only stations which do provide extended information, 
        /// false=show only stations without extended information.
        /// </summary>
        [HttpUrlParam("has_extended_info")]
        public bool? HasExtendedInfo { get; set; }

        /// <summary>
        /// OPTIONAL, not set=display all, 
        /// true=show only stations which have https url, 
        /// false=show only stations that do stream unencrypted with http.
        /// </summary>
        [HttpUrlParam("is_https")]
        public bool? IsHttps { get; set; }
    }
}
