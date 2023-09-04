using System.Threading.Tasks;
using RadioBrowserNet.Entities.Servers;

namespace RadioBrowserNet.Services.Implementations
{
    internal class Servers : BaseApi, IServers
    {
        public Servers(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task<ServerStats> GetStatsAsync()
        {
            return GetAsync<ServerStats>("stats");
        }

        public Task<ServerStats> GetStatsAsync(string serverUrl)
        {
            if (!serverUrl.EndsWith('/')) serverUrl += "/";

            return GetAsync<ServerStats>($"{serverUrl}json/stats");
        }

        public Task<ServerMirror[]> GetMirrorsAsync()
        {
            return GetAsync<ServerMirror[]>("servers");
        }

        public Task<ServerConfig> GetConfigAsync()
        {
            return GetAsync<ServerConfig>("config");
        }
    }
}
