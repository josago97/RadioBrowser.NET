using System.Threading.Tasks;
using RadioBrowserNet.Entities.Lists;

namespace RadioBrowserNet.Services.Implementations
{
    internal class Lists : BaseApi, ILists
    {
        public Lists(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task<CountryInfo[]> GetCountriesAsync(string? filter = null, ListQueryOptions? options = null)
        {
            return GetAsync<CountryInfo[]>("countries", filter, options);
        }

        public Task<CodecInfo[]> GetCodecsAsync(string? filter = null, ListQueryOptions? options = null)
        {
            return GetAsync<CodecInfo[]>("codecs", filter, options);
        }

        public Task<StateInfo[]> GetStatesAsync(string? filter = null, string? country = null, ListQueryOptions? options = null)
        {
            return GetAsync<StateInfo[]>("states", JoinFilters(country, filter), options);
        }

        public Task<LanguageInfo[]> GetLanguagesAsync(string? filter = null, ListQueryOptions? options = null)
        {
            return GetAsync<LanguageInfo[]>("languages", filter, options);
        }

        public Task<TagInfo[]> GetTagsAsync(string? filter = null, ListQueryOptions? options = null)
        {
            return GetAsync<TagInfo[]>("tags", filter, options);
        }
    }
}
