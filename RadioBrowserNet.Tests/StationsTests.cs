namespace RadioBrowserNet.Tests;

public class StationsTests : BaseRadioBrowserClientTest
{
    [Fact]
    public async Task GetAll()
    {
        StationInfo[] stations = await Client.Stations.GetAllAsync();

        Assert.True(stations.Length > 1000);
    }

    [Fact]
    public async Task AdvancedSearch()
    {
        AdvancedSearchOptions options = new AdvancedSearchOptions()
        {
            Limit = 10,
            Order = StationOrders.Votes,
            Reverse = true,
        };

        StationInfo[] stations = await Client.Stations.AdvancedSearchAsync(options);

        Assert.True(stations.Length == 10);
        Assert.True(stations.First().Votes > stations.Last().Votes);
    }

    [Fact]
    public async Task SearchByUuid()
    {
        Guid uuid = Guid.Parse("7fe99458-b6f2-4af0-95bc-e05977964622");
        StationInfo[] stations = await Client.Stations.SearchByUuidAsync(uuid);

        Assert.Single(stations);
    }

    [Fact]
    public async Task SearchByUuids()
    {
        Guid[] uuids = [
            Guid.Parse("7fe99458-b6f2-4af0-95bc-e05977964622"),
            Guid.Parse("9d69cc77-b698-40c0-8036-17cd1f09ca44")
        ];

        StationInfo[] stations = await Client.Stations.SearchByUuidAsync(uuids);

        Assert.Equal(uuids.Length, stations.Length);
    }

    [Fact]
    public async Task SearchByName()
    {
        StationInfo[] stations = await Client.Stations.SearchByNameAsync("kiss", false);
        Assert.NotEmpty(stations);

        StationInfo[] stationsExact = await Client.Stations.SearchByNameAsync("kiss", true);
        Assert.NotEmpty(stationsExact);
    }

    [Fact]
    public async Task GetByMostClicked()
    {
        StationInfo[] stations = await Client.Stations.GetByMostClickedAsync();
        Assert.NotEmpty(stations);

        StationInfo[] stationsSingle = await Client.Stations.GetByMostClickedAsync(1);
        Assert.NotEmpty(stationsSingle);
    }

    [Fact]
    public async Task GetByMostVoted()
    {
        StationInfo[] stations = await Client.Stations.GetByMostVotedAsync();
        Assert.NotEmpty(stations);

        StationInfo[] stationsSingle = await Client.Stations.GetByMostVotedAsync(1);
        Assert.NotEmpty(stationsSingle);
    }

    [Fact]
    public async Task GetByRecentClick()
    {
        StationInfo[] stations = await Client.Stations.GetByRecentClickAsync();
        Assert.NotEmpty(stations);

        StationInfo[] stationsSingle = await Client.Stations.GetByRecentClickAsync(1);
        Assert.NotEmpty(stationsSingle);
    }

    [Fact]
    public async Task GetByLastChanges()
    {
        StationInfo[] stations = await Client.Stations.GetByLastChangesAsync();
        Assert.NotEmpty(stations);

        StationInfo[] stationsSingle = await Client.Stations.GetByLastChangesAsync(1);
        Assert.NotEmpty(stationsSingle);
    }

    [Fact]
    public async Task GetBroken()
    {
        StationInfo[] stations = await Client.Stations.GetBrokenAsync();
        Assert.NotEmpty(stations);

        uint limit = 50;
        StationInfo[] stationsLimited = await Client.Stations.GetBrokenAsync(10, limit);
        Assert.NotEmpty(stationsLimited);
        Assert.Equal((int)limit, stationsLimited.Length);
    }

    [Fact]
    public async Task GetChecks()
    {
        StationCheck[] checks = await Client.Stations.GetChecksAsync(limit: 1000);
        Assert.NotEmpty(checks);

        Guid stationUuid = Guid.Parse("7fe99458-b6f2-4af0-95bc-e05977964622");
        StationCheck[] stationChecks = await Client.Stations.GetChecksAsync(stationUuid);
        Assert.NotEmpty(stationChecks);
    }

    [Fact]
    public async Task GetCheckSteps()
    {
        Guid[] uuids = [
            Guid.Parse("7fe99458-b6f2-4af0-95bc-e05977964622"),
            Guid.Parse("9d69cc77-b698-40c0-8036-17cd1f09ca44")
        ];

        StationCheckStep[] checkSteps = await Client.Stations.GetCheckStepsAsync(uuids);

        Assert.NotEmpty(checkSteps);
    }
}