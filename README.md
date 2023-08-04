# RadioBrowserNet

[![license](https://img.shields.io/badge/License-LGPL-darkgreen.svg)](https://github.com/josago97/RadioBrowserNet/blob/main/LICENSE) [![NuGet version (Sharplus)](https://img.shields.io/nuget/v/RadioBrowserNet.svg)](https://www.nuget.org/packages/RadioBrowserNet/) [![downloads](https://img.shields.io/nuget/dt/RadioBrowserNet.svg)](https://www.nuget.org/packages/RadioBrowserNet)

A .NET wrapper for https://www.radio-browser.info/
<br>
Documentation for the API can be found [here](https://api.radio-browser.info/)

### Samples
#### Simple search
```cs
RadioBrowserClient client = new RadioBrowserClient();
StationInfo[] stations = await client.Stations.SearchByNameAsync("station name");
```
```cs
RadioBrowserClient client = new RadioBrowserClient();
ExtendedQueryOptions options = new ExtendedQueryOptions()
{
    Order = "votes",
    Reverse = true
};
StationInfo[] stations = await client.Stations.SearchByNameAsync("station name", options: options);
StationInfo mostVoted = stations.First();
Console.WriteLine(mostVoted.Name);
```

#### Advanced search
To use advanced search use `AdvancedSearchOptions`

```c#
RadioBrowserClient client = new RadioBrowserClient();
StationInfo[] stations = await client.Stations.AdvancedAsync(new AdvancedSearchOptions
{
    Language = "spanish",
    Codec = "mp3",
    TagList = "80s",
    Limit = 10
});
```

#### Lists

```c#
// All countries
RadioBrowserClient client = new RadioBrowserClient();
CountryInfo[] countries = await client.Lists.GetCountriesAsync();
```

```c#
// Codecs containing the 'm' character
RadioBrowserClient client = new RadioBrowserClient();
CodecInfo[] codecs = await client.List.GetCodecsAsync("m");
```

#### Other
```cs
// Vote station
RadioBrowserClient client = new RadioBrowserClient();
ActionResult result = await client.Stations.VoteAsync("station uuid");
```
```cs
// Click station
RadioBrowserClient client = new RadioBrowserClient();
ClickResult result = await client.Stations.ClickAsync("station uuid");
```