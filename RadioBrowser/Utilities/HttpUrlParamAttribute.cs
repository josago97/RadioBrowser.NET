using System;

namespace RadioBrowser.Utilities
{
    [AttributeUsage(AttributeTargets.Property)]
    internal class HttpUrlParamAttribute : Attribute
    {
        public string Name { get; }
        public IHttpUrlParamParser Parser { get; }

        public HttpUrlParamAttribute(string name = null, Type typeParser = null) 
        {
            Name = name;

            if (typeParser != null)
            {
                Parser = (IHttpUrlParamParser)Activator.CreateInstance(typeParser);
            }
        }
    }
}
