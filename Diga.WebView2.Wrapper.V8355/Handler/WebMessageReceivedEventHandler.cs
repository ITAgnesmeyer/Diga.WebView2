using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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