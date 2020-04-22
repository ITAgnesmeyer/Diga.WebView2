using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceRequestedEventArgs : EventArgs, IWebView2WebResourceRequestedEventArgs2
    {
        private IWebView2WebResourceRequestedEventArgs2 _Args;

        public WebResourceRequestedEventArgs(IWebView2WebResourceRequestedEventArgs2 args)
        {
            this._Args = args;
        }

        private IWebView2WebResourceRequestedEventArgs2 ToInterface()
        {
            return this;
        }

        private IWebView2WebResourceRequestedEventArgs ToInterface0()
        {
            return this;
        }

        public WebResourceRequest Request {
            get
            {
                if(this.ToInterface().Request == null) return null;
                return new WebResourceRequest(this.ToInterface().Request);
            }
    }

        public WebResourceResponse Response
        {
            get
            {
                if(this.ToInterface().Response == null) return null;
                return new WebResourceResponse(this.ToInterface().Response);
            }
            set
            {
                this.ToInterface().Response = value;
            }
        }

        IWebView2WebResourceResponse IWebView2WebResourceRequestedEventArgs2.Response
        {
            get => this._Args.Response;
            set => this._Args.Response = value;
        }

        IWebView2Deferral IWebView2WebResourceRequestedEventArgs2.GetDeferral()
        {
            return this._Args.GetDeferral();
        }

        void IWebView2WebResourceRequestedEventArgs2.resourceContext(ref WEBVIEW2_WEB_RESOURCE_CONTEXT context)
        {
            this._Args.resourceContext(ref context);
        }


        IWebView2WebResourceRequest IWebView2WebResourceRequestedEventArgs.Request => ((IWebView2WebResourceRequestedEventArgs)this._Args).Request;

        IWebView2WebResourceRequest IWebView2WebResourceRequestedEventArgs2.Request => this._Args.Request;

        IWebView2WebResourceResponse IWebView2WebResourceRequestedEventArgs.Response
        {
            get => ((IWebView2WebResourceRequestedEventArgs)this._Args).Response;
            set => ((IWebView2WebResourceRequestedEventArgs)this._Args).Response = value;
        }

        IWebView2Deferral IWebView2WebResourceRequestedEventArgs.GetDeferral()
        {
            return ((IWebView2WebResourceRequestedEventArgs)this._Args).GetDeferral();
        }
    }
}