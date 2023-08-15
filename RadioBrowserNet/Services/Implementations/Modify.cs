using System;
using System.Threading.Tasks;
using RadioBrowserNet.Utilities;

namespace RadioBrowserNet.Services.Implementations
{
    internal class Modify : BaseApi, IModify
    {
        public Modify(HttpClient httpClient) : base(httpClient)
        {
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
