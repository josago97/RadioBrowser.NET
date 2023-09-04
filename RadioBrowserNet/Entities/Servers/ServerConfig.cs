using System;

namespace RadioBrowserNet.Entities.Servers
{
    public class ServerConfig
    {
        public bool CheckEnabled { get; set; }
        public bool PrometheusExporterEnabled { get; set; }
        public Uri[] PullServers { get; set; }
        public int TcpTimeoutSeconds { get; set; }
        public int BrokenStationsNeverWorkingTimeoutSeconds { get; set; }
        public int BrokenStationsTimeoutSeconds { get; set; }
        public int ChecksTimeoutSeconds { get; set; }
        public int ClickValidTimeoutSeconds { get; set; }
        public int ClickTimeoutSeconds { get; set; }
        public int MirrorPullIntervalSeconds { get; set; }
        public int UpdateCachesIntervalSeconds { get; set; }
        public string ServerName { get; set; }
        public string ServerLocation { get; set; }
        public string ServerCountryCode { get; set; }
        public int CheckRetries { get; set; }
        public int CheckBatchSize { get; set; }
        public int CheckPauseSeconds { get; set; }
        public int ApiThreads { get; set; }
        public string CacheType { get; set; }
        public int CacheTtl { get; set; }
    }
}
