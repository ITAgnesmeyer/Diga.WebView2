using Diga.WebView2.Interop;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceRequest : ICoreWebView2WebResourceRequest
    {

        private ICoreWebView2WebResourceRequest _Interface;

        public WebResourceRequest(ICoreWebView2WebResourceRequest iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2WebResourceRequest ToInterface()
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

        public HttpRequestHeaders Headers
        {
            get
            {
                if(this.ToInterface().Headers == null) return null;
                return new HttpRequestHeaders(this.ToInterface().Headers);
            }
        }

        string ICoreWebView2WebResourceRequest.uri
        {
            get => this._Interface.uri;
            set => this._Interface.uri = value;
        }

        string ICoreWebView2WebResourceRequest.Method
        {
            get => this._Interface.Method;
            set => this._Interface.Method = value;
        }

        IStream ICoreWebView2WebResourceRequest.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
        }

        ICoreWebView2HttpRequestHeaders ICoreWebView2WebResourceRequest.Headers => this._Interface.Headers;
    }
}