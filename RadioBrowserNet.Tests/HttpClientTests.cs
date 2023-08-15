namespace RadioBrowserNet.Tests;

public class HttpClientTests
{
    [Fact]
    private async Task CreateWithoutApiUrl()
    {
        RadioBrowserClient client = new RadioBrowserClient();
        HttpResponseMessage response = await client.HttpClient.GetAsync(string.Empty);

        Assert.True(response.IsSuccessStatusCode);
    }

    [Fact]
    private async Task CreateWithApiUrl()
    {
        RadioBrowserClient client = new RadioBrowserClient("de1.api.radio-browser.info");
        HttpResponseMessage response = await client.HttpClient.GetAsync(string.Empty);

        Assert.True(response.IsSuccessStatusCode);
    }
}
