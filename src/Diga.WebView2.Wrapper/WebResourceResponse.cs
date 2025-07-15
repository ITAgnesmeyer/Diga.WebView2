using System.IO;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;

namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Represents a web resource response in WebView2, providing access to content, status code, reason phrase, and headers.
    /// </summary>
    public class WebResourceResponse : WebResourceResponseInterface
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebResourceResponse"/> class.
        /// </summary>
        /// <param name="iface">The underlying <see cref="ICoreWebView2WebResourceResponse"/> COM interface.</param>
        public WebResourceResponse(ICoreWebView2WebResourceResponse iface):base(iface)
        {
        }

        /// <summary>
        /// Gets the content stream of the response.
        /// </summary>
        public new Stream Content
        {
            get
            {
                if (base.Content == null) return null;
                return new ComStream(base.Content);
            }
        }

        /// <summary>
        /// Gets the HTTP status code of the response.
        /// </summary>
        public new int StatusCode => base.StatusCode;

        /// <summary>
        /// Gets or sets the reason phrase for the response.
        /// </summary>
        public new string ReasonPhrase
        {
            get => base.ReasonPhrase;
            set => base.ReasonPhrase = value;
        }

        /// <summary>
        /// Gets the HTTP response headers for the response.
        /// </summary>
        public new HttpResponseHeaders Headers
        {
            get
            {
                if (base.Headers == null) return null;
                return new HttpResponseHeaders(base.Headers);
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceResponse()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }
    }
}