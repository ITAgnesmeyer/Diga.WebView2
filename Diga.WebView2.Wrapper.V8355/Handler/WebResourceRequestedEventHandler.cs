using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceRequestedEventHandler : IWebView2WebResourceRequestedEventHandler
    {
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        public void Invoke(IWebView2WebView webview, IWebView2WebResourceRequestedEventArgs args)
        {
            OnWebResourceRequested(new WebResourceRequestedEventArgs(args));
        }

        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }
    }
}