using RadioBrowserNet.Services;
using RadioBrowserNet.Services.Implementations;

namespace RadioBrowserNet
{
    public class RadioBrowserClient
    {
        public ILists Lists { get; }
        public IModify Modify { get; }
        public IStations Stations { get; }
        public IServers Servers { get; }
        public System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// Create a RadioBrowserClient instance
        /// </summary>
        /// <param name="apiUrl">Optional custom API URL</param>
        /// <param name="userAgent">Optional custom user agent</param>
        public RadioBrowserClient(string? apiUrl = null, string? userAgent = null)
        {
            HttpClient httpClient = new HttpClient(apiUrl, userAgent);

            Lists = new Lists(httpClient);
            Modify = new Modify(httpClient);
            Stations = new Stations(httpClient);
            Servers = new Servers(httpClient);
            HttpClient = httpClient;
        }
    }
}
