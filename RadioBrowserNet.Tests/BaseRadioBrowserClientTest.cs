namespace RadioBrowserNet.Tests;

public abstract class BaseRadioBrowserClientTest
{
    protected RadioBrowserClient Client { get; }

    public BaseRadioBrowserClientTest()
    {
        Client = new RadioBrowserClient();
    }
}
