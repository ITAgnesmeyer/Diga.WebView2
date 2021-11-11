using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class ResponseInfo
    {
        private ResponseInfo()
        {
            Header = new Dictionary<string, string>();
        }
        public ResponseInfo(Stream stream) : this()
        {
            Stream = stream;
            Header.Add("date", DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'"));
            Header.Add("accept-ranges", "bytes");
            Header.Add("Access-Control-Allow-Origin", "*");
            Header.Add("content-length", Stream.Length.ToString());
            Header.Add("X-Content-Type-Options", "nosniff");

        }

        public ResponseInfo(byte[] bytes) : this(new MemoryStream(bytes)) { }

        public ResponseInfo(string content) : this(Encoding.UTF8.GetBytes(content)) { }
        public Stream Stream { get; }
        public int StatusCode { get; set; }
        public string StatusText { get; set; }
        public string ContentType { get; set; }
        public Dictionary<string, string> Header { get; }

        public string HeaderToString()
        {

            Header.Add("Cache-Control", "max-age=31536000, immutable");

            string headerString = "";
            headerString = $"HTTP/2 {StatusCode} {StatusText}\r\n";
            foreach (var headerValue in Header)
            {

                headerString += headerValue.Key + ":" + headerValue.Value;
                headerString += "\r\n";
            }

            if (!string.IsNullOrEmpty(headerString))
            {
                headerString += "\r\n";
            }

            return headerString;
        }
    }
}