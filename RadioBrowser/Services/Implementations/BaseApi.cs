using System.Threading.Tasks;
using RadioBrowser.Utilities;

namespace RadioBrowser.Services.Implementations
{
    internal abstract class BaseApi
    {
        protected HttpClient HttpClient { get; }

        public BaseApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected async Task<T> GetAsync<T>(string url)
        {
            return await HttpClient.GetAsync<T>(url);
        }

        protected async Task<T> GetAsync<T>(string baseUrl, object options)
        {
            string url = baseUrl;

            string optionsUrl = options?.ToHttpUrlParams();
            if (!string.IsNullOrEmpty(optionsUrl))
            {
                if (url.Contains('?'))
                    url += "&" + optionsUrl;
                else
                    url += "?" + optionsUrl;
            }

            return await GetAsync<T>(url);
        }
    }
}
