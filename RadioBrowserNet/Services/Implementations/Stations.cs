using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RadioBrowserNet.Services.Implementations
{
    internal class Stations : BaseApi, IStations
    {
        public Stations(HttpClient httpClient) : base(httpClient)
        {
        }

        public Task<StationInfo[]> GetAllAsync()
        {
            return GetStationsAsync();
        }

        public Task<StationInfo[]> AdvancedSearchAsync(AdvancedSearchOptions options)
        {
            return GetStationsAsync("search", options);
        }

        public Task<StationInfo[]> SearchByUuidAsync(Guid uuid, StationQueryOptions? options = null)
        {
            return GetStationsAsync($"byuuid/{uuid}", options);
        }

        public Task<StationInfo[]> SearchByUuidAsync(IEnumerable<Guid> uuids, StationQueryOptions? options = null)
        {
            return GetStationsAsync($"byuuid?uuids={string.Join(',', uuids)}", options);
        }

        public Task<StationInfo[]> SearchByNameAsync(string name, bool exact = false, StationQueryOptions? options = null)
        {
            string url = exact ? $"bynameexact/{name}" : $"byname/{name}";

            return GetStationsAsync(url, options);
        }

        public Task<StationInfo[]> SearchByUrlAsync(string url, StationQueryOptions? options = null)
        {
            return GetStationsAsync($"byurl/{url}", options);
        }



        public Task<StationInfo[]> GetByMostClickedAsync(uint limit = 0, QueryOptions? options = null)
        {
            return GetStationsAsync("topclick", limit, options);
        }

        public Task<StationInfo[]> GetByMostVotedAsync(uint limit = 0, QueryOptions? options = null)
        {
            return GetStationsAsync("topvote", limit, options);
        }

        public Task<StationInfo[]> GetByRecentClickAsync(uint limit = 0, QueryOptions? options = null)
        {
            return GetStationsAsync("lastclick", limit, options);
        }

        public Task<StationInfo[]> GetByLastChangesAsync(uint limit = 0, QueryOptions options = null)
        {
            return GetStationsAsync("lastchange", limit, options);
        }

        public Task<StationInfo[]> GetBrokenAsync(uint offset = 0, uint limit = 1000)
        {
            return GetStationsAsync("broken", limit, new { Offset = offset });
        }

        private Task<StationInfo[]> GetStationsAsync(string filter = null, object options = null)
        {
            return GetAsync<StationInfo[]>("stations", filter, options);
        }

        private Task<StationInfo[]> GetStationsAsync(string url, uint limit, object options)
        {
            if (limit > 0) url = $"{url}/{limit}";

            return GetStationsAsync(url, options);
        }



        public Task<StationCheck[]> GetChecksAsync(Guid? stationuuid = null, Guid? lastcheckuuid = null, uint seconds = 0, uint limit = 999999)
        {
            return GetAsync<StationCheck[]>("checks", stationuuid?.ToString(), new 
            {
                LastCheckUuid = lastcheckuuid,
                Seconds = seconds,
                Limit = limit
            });
        }

        public Task<StationCheckStep[]> GetCheckStepsAsync(IEnumerable<Guid> uuids)
        {
            return GetAsync<StationCheckStep[]>("checksteps", null, new { Uuids = string.Join(',', uuids) });
        }
    }
}
