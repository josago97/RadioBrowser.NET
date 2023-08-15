using RadioBrowserNet.Utilities;

namespace RadioBrowserNet.Tests
{
    public class ExtensionsTests
    {
        public ExtensionsTests()
        {
            new RadioBrowserClient();
        }

        [Fact]
        public void ToHttpUrlParams()
        {
            NewStation newStation = new NewStation()
            {
                Name = "My radio",
                Url = new Uri("https://myradio.es/live"),
                Homepage = new Uri("https://myradio.es"),
                Favicon = new Uri("https://myradio.es/icon.png"),
                Country = "Spain",
                CountryCode = "ES",
                State = "Andalusia",
                Language = "Spanish",
                Tags = "Flamenco,Verdiales",
                GeoLatitude = 36.720244,
                GeoLongitude = -4.4151554
            };

            string expected = "name=My+radio" +
                "&url=https%3a%2f%2fmyradio.es%2flive" +
                "&homepage=https%3a%2f%2fmyradio.es%2f" +
                "&favicon=https%3a%2f%2fmyradio.es%2ficon.png" +
                "&country=Spain" +
                "&countrycode=ES" +
                "&state=Andalusia" +
                "&language=Spanish" +
                "&tags=Flamenco%2cVerdiales" +
                "&geo_lat=36.720244" +
                "&geo_long=-4.4151554";

            Assert.Equal(expected, newStation.ToHttpUrlParams());
        }
    }
}
