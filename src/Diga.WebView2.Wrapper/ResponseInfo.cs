using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Represents information about an HTTP response, including headers, status, and content.
    /// </summary>
    /// <remarks>This class provides functionality to manage HTTP response details such as headers, status
    /// code,  status text, and content type. It supports initialization from byte arrays or string content and  allows
    /// conversion of headers to a formatted string. The class implements <see cref="IDisposable"/>  to manage resources
    /// associated with the response stream.</remarks>
    public class ResponseInfo : IDisposable
    {
        private bool disposedValue;

        /// <summary>
        /// Represents information about a response, including headers.
        /// </summary>
        /// <remarks>This constructor initializes a new instance of the <see cref="ResponseInfo"/> class
        /// with an empty collection of headers.</remarks>
        private ResponseInfo()
        {
            this.Header = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo"/> class with the specified stream.
        /// </summary>
        /// <remarks>This constructor sets up default HTTP headers for the response, including the current
        /// date, content length, and access control settings. The stream's length is used to set the "content-length"
        /// header. Ensure that the provided stream is valid and open, as its length is accessed during
        /// initialization.</remarks>
        /// <param name="stream">The stream from which the response content is derived. Must not be null.</param>
        private ResponseInfo(Stream stream) : this()
        {
            this.Stream = stream;
            this.Header.Add("date", DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'"));
            this.Header.Add("accept-ranges", "bytes");
            this.Header.Add("Access-Control-Allow-Origin", "*");
            this.Header.Add("content-length", Stream.Length.ToString());
            this.Header.Add("X-Content-Type-Options", "nosniff");

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo"/> class using the specified byte array.
        /// </summary>
        /// <remarks>This constructor creates a <see cref="MemoryStream"/> from the provided byte array
        /// and initializes the <see cref="ResponseInfo"/> instance with it.</remarks>
        /// <param name="bytes">The byte array containing the data to initialize the <see cref="ResponseInfo"/> instance.</param>
        public ResponseInfo(byte[] bytes) : this(new MemoryStream(bytes)) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseInfo"/> class using the specified content string.
        /// </summary>
        /// <param name="content">The content string to be converted to a byte array using UTF-8 encoding.</param>
        public ResponseInfo(string content) : this(Encoding.UTF8.GetBytes(content)) { }

        /// <summary>
        /// Gets the stream used for reading and writing data.
        /// </summary>
        public Stream Stream { get; private set; }

        /// <summary>
        /// Gets or sets the HTTP status code associated with the response.
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status message associated with the current operation.
        /// </summary>
        public string StatusText { get; set; }

        /// <summary>
        /// Gets or sets the MIME type of the content.
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Gets the collection of HTTP headers associated with the request.
        /// </summary>
        public Dictionary<string, string> Header { get; }

        /// <summary>
        /// Converts the HTTP headers and status information into a formatted string representation.
        /// </summary>
        /// <remarks>This method ensures that the "Cache-Control" header is set to "max-age=31536000,
        /// immutable" before constructing the string. The resulting string includes the HTTP status line followed by
        /// each header key-value pair, each on a new line, and ends with an additional newline.</remarks>
        /// <returns>A string representing the HTTP/2 status line and headers, formatted for transmission.</returns>
        public string HeaderToString()
        {
            try
            {
                if (!Header.ContainsKey("Cache-Control"))
                {
                    Header.Add("Cache-Control", "max-age=31536000, immutable");
                }
                else
                {
                    Header["Cache-Control"] = "max-age=31536000, immutable";
                }
                    


            }
            catch (Exception e)
            {
                Debug.Print(e.StackTrace);                
            }
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
        /// <summary>
        /// Releases the unmanaged resources used by the class and optionally releases the managed resources.
        /// </summary>
        /// <remarks>This method is called by the public <c>Dispose</c> method and the finalizer. When
        /// <paramref name="disposing"/> is <see langword="true"/>, this method releases all resources held by any
        /// managed objects that this instance references. This method should be overridden by derived classes to
        /// release resources specific to those classes.</remarks>
        /// <param name="disposing"><see langword="true"/> to release both managed and unmanaged resources; <see langword="false"/> to release
        /// only unmanaged resources.</param>
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

        /// <summary>
        /// Releases all resources used by the current instance of the <see cref="ResponseInfo"/> class.
        /// </summary>
        /// <remarks>This method should be called when the instance is no longer needed to free up
        /// resources. It calls the <c>Dispose(bool disposing)</c> method with the <see langword="true"/> argument and
        /// suppresses finalization to optimize garbage collection.</remarks>
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}