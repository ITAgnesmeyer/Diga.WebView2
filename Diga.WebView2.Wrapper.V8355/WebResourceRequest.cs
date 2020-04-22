using Diga.WebView2.Interop;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
   
    public class WebResourceResponse : IWebView2WebResourceResponse
    {
        private IWebView2WebResourceResponse _Interface;

        public WebResourceResponse()
        {
            this._Interface = this.Tointerface();
        }
        public WebResourceResponse(IWebView2WebResourceResponse iface)
        {
            this._Interface = iface;
        }

        private IWebView2WebResourceResponse Tointerface()
        {
            return this;
        }



        public StreamWrapper Content
        {
            get
            {
                if (this.Tointerface().Content == null) return null;
                return new StreamWrapper(this.Tointerface().Content);
            }
        }

        public int StatusCode => this.Tointerface().StatusCode;

        public string ReasonPhrase
        {
            get => this.Tointerface().ReasonPhrase;
            set => this.Tointerface().ReasonPhrase = value;
        } 

        IStream IWebView2WebResourceResponse.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
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

    public class WebResourceRequest : IWebView2WebResourceRequest
    {

        private IWebView2WebResourceRequest _Interface;

        public WebResourceRequest(IWebView2WebResourceRequest iface)
        {
            this._Interface = iface;
        }

        private IWebView2WebResourceRequest ToInterface()
        {
            return this;
        }

        public string Uri => this.ToInterface().uri;

        public string Method
        {
            get => this.ToInterface().Method;
            set => this.ToInterface().Method = value;
        }

        public StreamWrapper Content
        {
            get
            {
                if (this.ToInterface().Content == null) return null;
                return new StreamWrapper(this.ToInterface().Content);
            }
            set
            {

                this.ToInterface().Content = value;
            }
        }

        string IWebView2WebResourceRequest.uri
        {
            get => this._Interface.uri;
            set => this._Interface.uri = value;
        }

        string IWebView2WebResourceRequest.Method
        {
            get => this._Interface.Method;
            set => this._Interface.Method = value;
        }

        IStream IWebView2WebResourceRequest.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
        }

        IWebView2HttpRequestHeaders IWebView2WebResourceRequest.Headers => this._Interface.Headers;
    }
}