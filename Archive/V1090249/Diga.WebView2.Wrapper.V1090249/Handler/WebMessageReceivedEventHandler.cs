using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebMessageReceivedEventHandler : ICoreWebView2WebMessageReceivedEventHandler
    {
        public event EventHandler<WebMessageReceivedEventArgs> WebMessageReceived;
       

        protected virtual void OnWebMessageReceived(WebMessageReceivedEventArgs e)
        {
            WebMessageReceived?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2WebMessageReceivedEventArgs args)
        {
            OnWebMessageReceived(new WebMessageReceivedEventArgs(args));
        }
    }
}