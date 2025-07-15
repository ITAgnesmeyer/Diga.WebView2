using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Represents information about an HTTP request, including its URI, method, content, and headers.
    /// </summary>
    /// <remarks>This class provides a way to encapsulate the details of an HTTP request. It extracts and
    /// stores the URI, HTTP method, content, and headers from a given <see cref="WebResourceRequest"/>
    /// object.</remarks>
    public class RequestInfo
    {
        /// <summary>
        /// Gets the URI of the request.
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Gets the HTTP method associated with the request.
        /// </summary>
        public string Method { get; }

        /// <summary>
        /// Gets the content as a string.
        /// </summary>
        public string Content { get; private set; }

        /// <summary>
        /// Gets the collection of HTTP headers associated with the request.
        /// </summary>
        public Dictionary<string, string> Headers { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestInfo"/> class using the specified web resource request.
        /// </summary>
        /// <remarks>This constructor sets up the request information by copying the URI, method, and
        /// headers from the provided <paramref name="resquest"/>. It also initializes the content to an empty string
        /// and reads the content from the request.</remarks>
        /// <param name="resquest">The web resource request containing the URI, method, content, and headers to initialize the request
        /// information.</param>
        public RequestInfo(WebResourceRequest resquest)
        {
            this.Headers = new Dictionary<string, string>();
            this.Uri = resquest.Uri;
            this.Method = resquest.Method;
            this.Content = string.Empty;
            ReadContent(resquest.Content);

            CopyHeaer(resquest.Headers);

        }

        /// <summary>
        /// Reads the content from the specified stream and stores it in the <see cref="Content"/> property.
        /// </summary>
        /// <remarks>If <paramref name="contentStream"/> is <see langword="null"/>, the method returns
        /// immediately without performing any action. The content is read using UTF-8 encoding.</remarks>
        /// <param name="contentStream">The stream from which to read the content. Must not be <see langword="null"/>.</param>
        private void ReadContent(Stream contentStream)
        {
            if (contentStream == null) return;
            try
            {
                using (StreamReader sr = new StreamReader(contentStream, Encoding.UTF8))
                {
                    this.Content = sr.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Debug.Print("ReadContent exception:" + e.Message);
            }
        }

        /// <summary>
        /// Copies all headers from the specified <see cref="HttpRequestHeaders"/> to the current instance.
        /// </summary>
        /// <remarks>This method iterates over the provided headers and adds each key-value pair to the
        /// current instance's headers collection.</remarks>
        /// <param name="headers">The <see cref="HttpRequestHeaders"/> containing the headers to copy. If <paramref name="headers"/> is <see
        /// langword="null"/>, the method returns without performing any action.</param>
        private void CopyHeaer(HttpRequestHeaders headers)
        {
            if (headers == null)
                return;
            var iterator = headers.GetIterator();
            if (iterator == null) return;
            if (iterator.HasCurrent)
            {
                string key = iterator.Current.Name;
                string value = iterator.Current.Value;
                this.Headers.Add(key, value);
            }

            while (iterator.MoveNext())
            {
                string key = iterator.Current.Name;
                string value = iterator.Current.Value;
                this.Headers.Add(key, value);
            }
        }

    }
}