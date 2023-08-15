using RadioBrowserNet.Entities.Lists;

namespace RadioBrowserNet.Tests;

public class ListsTests : BaseRadioBrowserClientTest
{
    [Fact]
    private async Task GetCountries()
    {
        await GetAll(Client.Lists.GetCountriesAsync);
        await GetByFilters(Client.Lists.GetCountriesAsync);
    }

    [Fact]
    private async Task GetCodecs()
    {
        await GetAll(Client.Lists.GetCodecsAsync);
        await GetByFilters(Client.Lists.GetCodecsAsync);
    }

    [Fact]
    private async Task GetStates()
    {
        await GetAll((_, __) => Client.Lists.GetStatesAsync());
        await GetAll((_, __) => Client.Lists.GetStatesAsync("spain"));
        await GetByFilters((filter, options) => Client.Lists.GetStatesAsync(null, filter, options));
        await GetByFilters((filter, options) => Client.Lists.GetStatesAsync("united states", filter, options));
    }

    [Fact]
    private async Task GetLanguages()
    {
        await GetAll(Client.Lists.GetLanguagesAsync);
        await GetByFilters(Client.Lists.GetLanguagesAsync);
    }

    [Fact]
    private async Task GetTags()
    {
        await GetAll(Client.Lists.GetTagsAsync);
        await GetByFilters(Client.Lists.GetTagsAsync);
    }

    private async Task GetAll<T>(Func<string, ListQueryOptions, Task<T[]>> funcTask)
    {
        T[] result = await funcTask(null, null);

        Assert.NotNull(result);
        Assert.NotEmpty(result);
    }

    private async Task GetByFilters<T>(Func<string, ListQueryOptions, Task<T[]>> funcTask)
    {
        ListQueryOptions options = new ListQueryOptions()
        {
            Limit = 10,
        };

        T[] result = await funcTask("a", options);

        Assert.NotNull(result);
        Assert.True(options.Limit >= result.Length);
    }
}
