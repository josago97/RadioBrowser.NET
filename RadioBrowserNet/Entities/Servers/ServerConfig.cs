using System;
using System.Text.Json.Serialization;

namespace RadioBrowserNet.Entities.Servers
{
    public class ServerConfig
    {
        [JsonPropertyName("check_enabled")]
        public bool CheckEnabled { get; set; }

        [JsonPropertyName("prometheus_exporter_enabled")]
        public bool PrometheusExporterEnabled { get; set; }

        [JsonPropertyName("pull_servers")]
        public Uri[] PullServers { get; set; }

        [JsonPropertyName("tcp_timeout_seconds")]
        public int TcpTimeoutSeconds { get; set; }

        [JsonPropertyName("broken_stations_never_working_timeout_seconds")]
        public int BrokenStationsNeverWorkingTimeoutSeconds { get; set; }

        [JsonPropertyName("broken_stations_timeout_seconds")]
        public int BrokenStationsTimeoutSeconds { get; set; }

        [JsonPropertyName("checks_timeout_seconds")]
        public int ChecksTimeoutSeconds { get; set; }

        [JsonPropertyName("click_valid_timeout_seconds")]
        public int ClickValidTimeoutSeconds { get; set; }

        [JsonPropertyName("clicks_timeout_seconds")]
        public int ClicksTimeoutSeconds { get; set; }

        [JsonPropertyName("mirror_pull_interval_seconds")]
        public int MirrorPullIntervalSeconds { get; set; }

        [JsonPropertyName("update_caches_interval_seconds")]
        public int UpdateCachesIntervalSeconds { get; set; }

        [JsonPropertyName("server_name")]
        public string ServerName { get; set; }

        [JsonPropertyName("server_location")]
        public string ServerLocation { get; set; }

        [JsonPropertyName("server_country_code")]
        public string ServerCountryCode { get; set; }

        [JsonPropertyName("check_retries")]
        public int CheckRetries { get; set; }

        [JsonPropertyName("check_batchsize")]
        public int CheckBatchSize { get; set; }

        [JsonPropertyName("check_pause_seconds")]
        public int CheckPauseSeconds { get; set; }

        [JsonPropertyName("api_threads")]
        public int ApiThreads { get; set; }

        [JsonPropertyName("cache_type")]
        public string CacheType { get; set; }

        [JsonPropertyName("cache_ttl")]
        public int CacheTtl { get; set; }

        [JsonPropertyName("language_replace_filepath")]
        public string LanguageReplaceFilepath { get; set; }

        [JsonPropertyName("language_to_code_filepath")]
        public string LanguageToCodeFilepath { get; set; }
    }
}
