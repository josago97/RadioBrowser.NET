using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioBrowserNet.Utilities;

namespace RadioBrowserNet.Services.Implementations
{
    internal abstract class BaseApi
    {
        protected HttpClient HttpClient { get; }

        public BaseApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected Task<T> GetAsync<T>(string url)
        {
            return HttpClient.GetAsync<T>(url);
        }

        protected Task<T> GetAsync<T>(string baseUrl, string filter, object options = null)
        {
            string url = baseUrl;

            if (!string.IsNullOrEmpty(filter)) url += '/' + filter;

            string optionsUrl = options?.ToHttpUrlParams();
            if (!string.IsNullOrEmpty(optionsUrl))
            {
                if (url.Contains('?'))
                    url += "&" + optionsUrl;
                else
                    url += "?" + optionsUrl;
            }

            return GetAsync<T>(url);
        }

        protected string JoinFilters(params string[] filters)
        {
            return string.Join('/', filters.Where(s => !string.IsNullOrEmpty(s)));
        }

        /*
        protected Task<T> GetAsync<T>(string baseUrl, object options)
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

            return GetAsync<T>(url);
        }

        protected Task<T> GetAsync<T>(string baseUrl, object options, params string[] filters)
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

            return GetAsync<T>(url);
        }

        */
    }
}
