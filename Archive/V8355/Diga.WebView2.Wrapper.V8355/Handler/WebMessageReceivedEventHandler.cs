using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebMessageReceivedEventHandler : IWebView2WebMessageReceivedEventHandler
    {
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
        public void Invoke(IWebView2WebView webview, IWebView2WebMessageReceivedEventArgs args)
        {
            OnWebMessageReceived(new WebMessageReceivedEventArgs(args));
        }

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }
    }
}