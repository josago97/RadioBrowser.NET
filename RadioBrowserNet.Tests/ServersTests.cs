using RadioBrowserNet.Entities.Servers;

namespace RadioBrowserNet.Tests;

public class ServersTests : BaseRadioBrowserClientTest
{
    [Fact]
    private async Task GetStats()
    {
        ServerStats stats = await Client.Servers.GetStatsAsync();
        Assert.NotNull(stats);

        ServerStats stats2 = await Client.Servers.GetStatsAsync("http://de1.api.radio-browser.info/");
        Assert.NotNull(stats2);
    }

    [Fact]
    private async Task GetMirrors()
    {
        ServerMirror[] mirrors = await Client.Servers.GetMirrorsAsync();
        Assert.NotEmpty(mirrors);
    }

    [Fact]
    private async Task GetConfig()
    {
        ServerConfig config = await Client.Servers.GetConfigAsync();
        Assert.NotNull(config);
    }
}
