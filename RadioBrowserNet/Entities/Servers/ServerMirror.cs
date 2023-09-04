using System;
using System.Net;
using System.Text.Json.Serialization;
using RadioBrowserNet.Utilities.JsonConverters;

namespace RadioBrowserNet.Entities.Servers
{
    public class ServerMirror
    {
        [JsonConverter(typeof(IpAddressConverter))]
        public IPAddress Ip { get; set; }

        public string Name { get; set; }
    }
}
