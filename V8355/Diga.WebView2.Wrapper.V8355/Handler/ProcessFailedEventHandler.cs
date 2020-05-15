using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
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