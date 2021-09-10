using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebResourceRequestedEventHandler : IWebView2WebResourceRequestedEventHandler
    {
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public void Invoke(IWebView2WebView webview, IWebView2WebResourceRequestedEventArgs2 args)
        {
            OnWebResourceRequested(new WebResourceRequestedEventArgs(args));
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }
    }
}