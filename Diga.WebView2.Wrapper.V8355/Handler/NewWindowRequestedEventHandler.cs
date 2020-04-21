using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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