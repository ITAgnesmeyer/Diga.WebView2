using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceRequestedEventArgs : EventArgs, IWebView2WebResourceRequestedEventArgs
    {
        private IWebView2WebResourceRequestedEventArgs _Args;

        public WebResourceRequestedEventArgs(IWebView2WebResourceRequestedEventArgs args)
        {
            this._Args = args;
        }

        private IWebView2WebResourceRequestedEventArgs ToInterface()
        {
            return this;
        }

        public WebResourceRequest Request => new WebResourceRequest(this._Args.Request);
        

        IWebView2WebResourceRequest IWebView2WebResourceRequestedEventArgs.Request => this._Args.Request;

        IWebView2WebResourceResponse IWebView2WebResourceRequestedEventArgs.Response
        {
            get => this._Args.Response;
            set => this._Args.Response = value;
        }

        IWebView2Deferral IWebView2WebResourceRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
    }
}