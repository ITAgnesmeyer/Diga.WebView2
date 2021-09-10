using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NewWindowRequestedEventHandler : IWebView2NewWindowRequestedEventHandler
    {
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;
        public void Invoke(IWebView2WebView webview, IWebView2NewWindowRequestedEventArgs args)
        {
            OnNewWindowRequested(new NewWindowRequestedEventArgs(args));
        }

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }
    }
}