using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebResourceResponseReceivedEventArgs :EventArgs, ICoreWebView2WebResourceResponseReceivedEventArgs
    {
        private ICoreWebView2WebResourceResponseReceivedEventArgs _Args;
        

        public WebResourceResponseReceivedEventArgs(ICoreWebView2WebResourceResponseReceivedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebResourceResponseReceivedEventArgs Tointerface()
        {
            return this._Args;
        }

        public WebResourceRequest Request => new WebResourceRequest(this.Tointerface().Request);

        public WebResourceResponseView Response => new WebResourceResponseView(this.Tointerface().Response);
        ICoreWebView2WebResourceRequest ICoreWebView2WebResourceResponseReceivedEventArgs.Request => this._Args.Request;

        ICoreWebView2WebResourceResponseView ICoreWebView2WebResourceResponseReceivedEventArgs.Response => this._Args.Response;
    }
}