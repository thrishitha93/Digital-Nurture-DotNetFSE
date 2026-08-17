using System;

namespace UtilLib
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("URL cannot be empty");

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                throw new FormatException("Invalid URL format");

            Uri uri = new Uri(url);
            return uri.Host;
        }
    }
}