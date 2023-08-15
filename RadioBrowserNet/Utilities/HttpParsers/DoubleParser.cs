using System.Globalization;

namespace RadioBrowserNet.Utilities.HttpParsers
{
    internal class DoubleParser : IHttpUrlParamParser
    {
        public string Parse(object value)
        {
            double number = (double)value;

            return number.ToString("0.########", CultureInfo.InvariantCulture);
        }
    }
}
