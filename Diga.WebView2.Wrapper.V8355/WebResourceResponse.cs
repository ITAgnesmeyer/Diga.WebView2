using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceResponse : IWebView2WebResourceResponse
    {
        private IWebView2WebResourceResponse _Interface;

        public WebResourceResponse()
        {
            this._Interface = this.ToInterface();
        }
        public WebResourceResponse(IWebView2WebResourceResponse iface)
        {
            this._Interface = iface;
        }

        private IWebView2WebResourceResponse ToInterface()
        {
            return this;
        }



        public StreamWrapper Content
        {
            get
            {
                if (this.ToInterface().Content == null) return null;
                return new StreamWrapper(this.ToInterface().Content);
            }
        }

        public int StatusCode => this.ToInterface().StatusCode;

        public string ReasonPhrase
        {
            get => this.ToInterface().ReasonPhrase;
            set => this.ToInterface().ReasonPhrase = value;
        } 

      

        IStream IWebView2WebResourceResponse.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
        }

        public HttpResponseHeaders Headers
        {
            get
            {
                if(this.ToInterface().Headers == null) return null;
                return new HttpResponseHeaders(this.ToInterface().Headers);
            }
        }
        IWebView2HttpResponseHeaders IWebView2WebResourceResponse.Headers => this._Interface.Headers;

        int IWebView2WebResourceResponse.StatusCode
        {
            get => this._Interface.StatusCode;
            set => this._Interface.StatusCode = value;
        }

        string IWebView2WebResourceResponse.ReasonPhrase
        {
            get => this._Interface.ReasonPhrase;
            set => this._Interface.ReasonPhrase = value;
        }
    }
}