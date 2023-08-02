using RadioBrowser.Services.Implementations;

namespace RadioBrowser
{
    public class RadioBrowserClient
    {
        public ILists Lists { get; }
        public IStations Stations { get; }
        public System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// Create a RadioBrowserClient instance
        /// </summary>
        /// <param name="apiUrl">Optional custom API URL</param>
        /// <param name="userAgent">Optional custom user agent</param>
        public RadioBrowserClient(string apiUrl = null, string userAgent = null)
        {
            HttpClient httpClient = new HttpClient(apiUrl, userAgent);

            Lists = new Lists(httpClient);
            Stations = new Stations(httpClient);
            HttpClient = httpClient;
        }
    }
}
