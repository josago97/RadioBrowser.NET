using System.Linq;
using System.Threading.Tasks;

namespace RadioBrowser.Services.Implementations
{
    internal class Lists : BaseApi, ILists
    {
        public Lists(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<CountryInfo[]> GetCountriesAsync(string filter = null, ExtendedQueryOptions options = null)
        {
            return await GetAsync<CountryInfo[]>(GetUrl("countries", filter), options);
        }

        public async Task<CodecInfo[]> GetCodecsAsync(string filter = null, ExtendedQueryOptions options = null)
        {
            return await GetAsync<CodecInfo[]>(GetUrl("codecs", filter), options);
        }

        public async Task<StateInfo[]> GetStatesAsync(string filter = null, string country = null, ExtendedQueryOptions options = null)
        {
            return await GetAsync<StateInfo[]>(GetUrl("states", country, filter), options);
        }

        public async Task<LanguageInfo[]> GetLanguagesAsync(string filter = null, ExtendedQueryOptions options = null)
        {
            return await GetAsync<LanguageInfo[]>(GetUrl("languages", filter), options);
        }

        public async Task<TagInfo[]> GetTagsAsync(string filter = null, ExtendedQueryOptions options = null)
        {
            return await GetAsync<TagInfo[]>(GetUrl("tags", filter), options);
        }

        private string GetUrl(string baseUrl, params string[] filters)
        {
            string result = baseUrl;

            string filtersUrl = string.Join('/', filters.Where(s => !string.IsNullOrEmpty(s)));
            if (!string.IsNullOrEmpty(filtersUrl)) result += "/" + filtersUrl;

            return result;
        }
    }
}
