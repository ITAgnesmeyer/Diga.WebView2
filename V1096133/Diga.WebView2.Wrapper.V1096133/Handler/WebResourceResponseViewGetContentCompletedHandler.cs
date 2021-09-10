using System;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebResourceResponseViewGetContentCompletedHandler : ICoreWebView2WebResourceResponseViewGetContentCompletedHandler
    {
        public event EventHandler<WebView2StreamEventArgs> WebResourceResponseViewGetContent;
        private ICoreWebView2WebResourceResponseViewGetContentCompletedHandler _Interface;

        public WebResourceResponseViewGetContentCompletedHandler()
        {
            this._Interface = this.ToInterface();
        }
        public WebResourceResponseViewGetContentCompletedHandler(ICoreWebView2WebResourceResponseViewGetContentCompletedHandler iface)
        {
            _Interface = iface;
        }

        private ICoreWebView2WebResourceResponseViewGetContentCompletedHandler ToInterface()
        {
            return this;
        }
        public void Invoke(int errorCode, IStream Content)
        {
            OnWebResourceResponseViewGetContent(new WebView2StreamEventArgs(errorCode, Content));
        }

        protected virtual void OnWebResourceResponseViewGetContent(WebView2StreamEventArgs e)
        {
            WebResourceResponseViewGetContent?.Invoke(this, e);
        }

        void ICoreWebView2WebResourceResponseViewGetContentCompletedHandler.Invoke(int errorCode, IStream Content) =>
            this._Interface.Invoke(errorCode, Content);
    }
}