using System.Threading.Tasks;
using RadioBrowserNet.Entities.Servers;

namespace RadioBrowserNet.Services
{
    public interface IServers
    {
        Task<ServerStats> GetStatsAsync();

        Task<ServerStats> GetStatsAsync(string serverUrl);

        Task<ServerMirror[]> GetMirrorsAsync();

        Task<ServerConfig> GetConfigAsync();
    }
}
