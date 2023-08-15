using System;

namespace RadioBrowserNet.Utilities.HttpParsers
{
    internal class OrderParser : IHttpUrlParamParser
    {
        public string Parse(object value)
        {
            Enum enumeration = (Enum)value;

            return enumeration.ToString().ToLower();
        }
    }
}
