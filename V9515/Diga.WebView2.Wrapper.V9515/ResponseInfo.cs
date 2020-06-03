using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.WinForms
{
    public class ResponseInfo
    {
        private ResponseInfo()
        {
            this.Header = new Dictionary<string, string>();
        }
        public ResponseInfo(Stream stream) : this()
        {
            this.Stream = stream;
            this.Header.Add("date", DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'"));
            this.Header.Add("accept-ranges", "bytes");
            this.Header.Add("Access-Control-Allow-Origin", "*");
            this.Header.Add("content-length", this.Stream.Length.ToString());
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
            string headerString = "";
            headerString = $"HTTP/2 {this.StatusCode} {this.StatusText}\r\n";
            foreach (var headerValue in this.Header)
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