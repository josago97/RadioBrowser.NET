using System.Threading.Tasks;
using RadioBrowserNet.Entities.Servers;

namespace RadioBrowserNet.Services
{
    public interface IServers
    {
        /// <summary>
        /// Gets current server statistics.
        /// </summary>
        /// <returns>Web service stats.</returns>
        Task<ServerStats> GetStatsAsync();

        /// <summary>
        /// Gets statistics of a server.
        /// </summary>
        /// <param name="serverUrl">Server url.</param>
        /// <returns>Web service stats.</returns>
        Task<ServerStats> GetStatsAsync(string serverUrl);

        /// <summary>
        /// A DNS look-up of all.api.radio-browser.info is performed followed by a reverse one for every result getting from the first request. 
        /// This should be done on the client. ONLY USE THIS if your client is not able to do DNS look-ups.
        /// </summary>
        /// <returns>Ana array of server mirrors</returns>
        Task<ServerMirror[]> GetMirrorsAsync();

        /// <summary>
        /// Gets the current active server config.
        /// </summary>
        /// <returns>The current active server config.</returns>
        Task<ServerConfig> GetConfigAsync();
    }
}
