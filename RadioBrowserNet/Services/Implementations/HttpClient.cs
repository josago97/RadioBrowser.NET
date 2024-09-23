using System;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;

namespace RadioBrowserNet.Services.Implementations
{
    internal class HttpClient : System.Net.Http.HttpClient
    {
        private const string DNS_URL = "all.api.radio-browser.info";
        private const string DEFAULT_API_URL = "de1.api.radio-browser.info";

        private JsonSerializerOptions JsonSerializerOptions { get; }

        internal HttpClient(string? apiUrl = null, string? userAgent = null) : base()
        {
            BaseAddress = new Uri($"https://{apiUrl ?? GetRadioBrowserApiUrl() ?? DEFAULT_API_URL}");
            DefaultRequestHeaders.UserAgent.ParseAdd(userAgent ?? "Mozilla/5.0");
            JsonSerializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        }

        private string GetRadioBrowserApiUrl()
        {
            string result = null;

            try
            {
                // Get the best ip address
                IPAddress[] ips = Dns.GetHostAddresses(DNS_URL);
                long lastRoundTripTime = long.MaxValue;

                foreach (IPAddress ipAddress in ips)
                    try
                    {
                        PingReply reply = new Ping().Send(ipAddress);
                        if (reply != null && reply.RoundtripTime < lastRoundTripTime)
                        {
                            lastRoundTripTime = reply.RoundtripTime;
                            result = ipAddress.ToString();
                        }
                    }
                    catch (SocketException)
                    {
                        Trace.WriteLine("Cannot ping socket");
                    }

                // Get the host name
                IPHostEntry hostEntry = Dns.GetHostEntry(result);
                if (!string.IsNullOrEmpty(hostEntry.HostName)) result = hostEntry.HostName;
            }
            catch
            {
                Trace.WriteLine("Cannot use DNS");
            }

            return result;
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            string url = endpoint.StartsWith("http") ? endpoint : $"/json/{endpoint}";
            string json = await GetStringAsync(url);

            return JsonSerializer.Deserialize<T>(json, JsonSerializerOptions)!;
        }
    }
}
