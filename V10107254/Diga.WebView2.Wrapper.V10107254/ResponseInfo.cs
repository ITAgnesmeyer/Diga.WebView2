using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class ResponseInfo:IDisposable
    {
        private bool disposedValue;

        private ResponseInfo()
        {
            this.Header = new Dictionary<string, string>();
        }

        private ResponseInfo(Stream stream) : this()
        {
            this.Stream = stream;
            this.Header.Add("date", DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'"));
            this.Header.Add("accept-ranges", "bytes");
            this.Header.Add("Access-Control-Allow-Origin", "*");
            this.Header.Add("content-length", Stream.Length.ToString());
            this.Header.Add("X-Content-Type-Options", "nosniff");

        }

        public ResponseInfo(byte[] bytes) : this(new MemoryStream(bytes)) { }

        public ResponseInfo(string content) : this(Encoding.UTF8.GetBytes(content)) { }
        public Stream Stream { get; private set; }
        public int StatusCode { get; set; }
        public string StatusText { get; set; }
        public string ContentType { get; set; }
        public Dictionary<string, string> Header { get; }

        public string HeaderToString()
        {

            Header.Add("Cache-Control", "max-age=31536000, immutable");
            StringBuilder headerStringBuilder = new StringBuilder($"HTTP/2 {StatusCode} {StatusText}\r\n");

            //string headerString = "";
            //headerString = $"HTTP/2 {StatusCode} {StatusText}\r\n";
            foreach (var headerValue in this.Header)
            {
                headerStringBuilder.Append(headerValue.Key);
                headerStringBuilder.Append(":");
                headerStringBuilder.Append(headerValue.Value);
                headerStringBuilder.Append("\r\n");
                //headerString += headerValue.Key + ":" + headerValue.Value;
                //headerString += "\r\n";
            }

            //if (!string.IsNullOrEmpty(headerString))
            //{
            //    headerString += "\r\n";
            //}
            
            headerStringBuilder.Append("\r\n");
            //string h = headerStringBuilder.ToString();
            return headerStringBuilder.ToString();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (this.Stream != null)
                    {
                        this.Stream.Dispose();
                        this.Stream = null;
                    }
                }
               
               
                disposedValue = true;
            }
        }

        //~ResponseInfo()
        //{
        //    // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //    Dispose(disposing: false);
        //}

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}