using System;
using System.Collections.Generic;
using System.Reflection;
using System.Web;

namespace RadioBrowser.Utilities
{
    internal static class Extensions
    {
        public static string ToHttpUrlParams(this object instance)
        {
            List<string> httpParams = new List<string>();

            foreach (PropertyInfo property in instance.GetType().GetProperties())
            {
                object value = property.GetValue(instance, null);

                if (value != null)
                {
                    var httpParamAttribute = property.GetCustomAttribute<HttpUrlParamAttribute>(true);

                    string valueString = httpParamAttribute?.Parser?.Parse(value) ?? value.ToString();
                    string name = httpParamAttribute?.Name ?? property.Name.ToLower();

                    TypeCode propertyTypeCode = Type.GetTypeCode(property.PropertyType);

                    if (propertyTypeCode == TypeCode.Boolean)
                        valueString = valueString.ToLower();

                    httpParams.Add($"{name}={HttpUtility.UrlEncode(valueString)}");
                }
            }

            return string.Join("&", httpParams.ToArray());
        }
    }
}
