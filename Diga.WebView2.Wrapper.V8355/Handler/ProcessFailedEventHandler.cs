using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class ProcessFailedEventHandler : IWebView2ProcessFailedEventHandler
    {
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        public void Invoke(IWebView2WebView webview, IWebView2ProcessFailedEventArgs args)
        {
            OnProcessFailed(new ProcessFailedEventArgs(args));
        }

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }
    }
}