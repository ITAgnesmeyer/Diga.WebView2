using System;
using Diga.WebView2.Interop;
using System.Threading.Tasks;
namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebResourceRequestedEventArgs : EventArgs, ICoreWebView2WebResourceRequestedEventArgs
    {
        private ICoreWebView2WebResourceRequestedEventArgs _Args;

        public WebResourceRequestedEventArgs(ICoreWebView2WebResourceRequestedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebResourceRequestedEventArgs ToInterface()
        {
            return _Args;
        }

        public WebResourceRequest Request => new WebResourceRequest(this.ToInterface().Request);

        public WebResourceResponse Response
        {
            get
            {
                if (this.ToInterface().Response == null)
                    return null;
                return new WebResourceResponse(this.ToInterface().Response);
            }
            set
            {
                this.ToInterface().Response = value;
            }
        }

        ICoreWebView2WebResourceRequest ICoreWebView2WebResourceRequestedEventArgs.Request => this._Args.Request;

        ICoreWebView2WebResourceResponse ICoreWebView2WebResourceRequestedEventArgs.Response
        {
            get => this._Args.Response;
            set => this._Args.Response = value;
        }

        ICoreWebView2Deferral ICoreWebView2WebResourceRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT ICoreWebView2WebResourceRequestedEventArgs.ResourceContext => this._Args.ResourceContext;

    }
}