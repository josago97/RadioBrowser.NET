using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using RadioBrowser.Utilities;

namespace RadioBrowser.Services.Implementations
{
    internal class Stations : BaseApi, IStations
    {
        public Stations(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<StationInfo[]> GetAllAsync()
        {
            return await GetStationsAsync();
        }

        public async Task<StationInfo[]> AdvancedSearchAsync(AdvancedSearchOptions options)
        {
            return await GetStationsAsync("search", options);
        }

        public async Task<StationInfo[]> SearchByUuidAsync(Guid uuid, ExtendedQueryOptions options = null)
        {
            return await GetStationsAsync($"byuuid/{uuid}", options);
        }

        public async Task<StationInfo[]> SearchByUuidAsync(IEnumerable<Guid> uuids, ExtendedQueryOptions options = null)
        {
            return await GetStationsAsync($"byuuid?uuids={string.Join(',', uuids)}", options);
        }

        public async Task<StationInfo[]> SearchByNameAsync(string name, bool exact = false, ExtendedQueryOptions options = null)
        {
            string url = exact ? $"bynameexact/{name}" : $"byname/{name}";

            return await GetStationsAsync(url, options);
        }

        public async Task<StationInfo[]> SearchByUrlAsync(string url, ExtendedQueryOptions options = null)
        {
            return await GetStationsAsync($"byurl/{url}", options);
        }



        public async Task<StationInfo[]> GetByMostClickedAsync(uint limit = 0, QueryOptions options = null)
        {
            return await GetStationsAsync("topclick", limit, options);
        }

        public async Task<StationInfo[]> GetByMostVotedAsync(uint limit = 0, QueryOptions options = null)
        {
            return await GetStationsAsync("topvote", limit, options);
        }

        public async Task<StationInfo[]> GetByRecentClickAsync(uint limit = 0, QueryOptions options = null)
        {
            return await GetStationsAsync("lastclick", limit, options);
        }

        public async Task<StationInfo[]> GetByLastChangesAsync(uint limit = 0, QueryOptions options = null)
        {
            return await GetStationsAsync("lastchange", limit, options);
        }



        private async Task<StationInfo[]> GetStationsAsync(string url = null, object options = null)
        {
            string endpoint = "stations";
            if (!string.IsNullOrEmpty(url)) endpoint += '/' + url;

            return await GetAsync<StationInfo[]>(endpoint, options);
        }

        private async Task<StationInfo[]> GetStationsAsync(string url, uint limit, object options)
        {
            if (limit > 0) url = $"{url}/{limit}";

            return await GetStationsAsync(url, options);
        }



        public async Task<ClickResult> ClickAsync(Guid uuid)
        {
            return await GetAsync<ClickResult>($"/url/{uuid}");
        }

        public async Task<ActionResult> VoteAsync(Guid uuid)
        {
            return await GetAsync<ActionResult>($"/vote/{uuid}");
        }

        public async Task<AddStationResult> AddStationAsync(NewStation newStation)
        {
            return await GetAsync<AddStationResult>($"json/add/{newStation.ToHttpUrlParams()}");
        }
    }
}
