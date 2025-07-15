using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Represents a web resource request in WebView2, providing access to URI, method, content, and headers.
    /// </summary>
    public class WebResourceRequest : WebResourceRequestInterface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebResourceRequest"/> class.
        /// </summary>
        /// <param name="iface">The underlying <see cref="ICoreWebView2WebResourceRequest"/> COM interface.</param>
        public WebResourceRequest(ICoreWebView2WebResourceRequest iface):base(iface)
        {
        }

        /// <summary>
        /// Gets the URI of the web resource request.
        /// </summary>
        public string Uri => base.uri;

        /// <summary>
        /// Gets or sets the HTTP method for the request (e.g., GET, POST).
        /// </summary>
        public new string Method
        {
            get => base.Method;
            set => base.Method = value;
        }

        /// <summary>
        /// Gets or sets the content stream for the request.
        /// </summary>
        public new Stream Content
        {
            get
            {
                if (base.Content == null) return null;
                return new ComStream(base.Content);
            }
            set
            {
                base.Content = new ManagedIStream(ref value);
            }
        }

        /// <summary>
        /// Gets the HTTP request headers for the request.
        /// </summary>
        public new HttpRequestHeaders Headers
        {
            get
            {
                if (base.Headers == null) return null;
                return new HttpRequestHeaders(base.Headers);
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceRequest()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }
    }
}