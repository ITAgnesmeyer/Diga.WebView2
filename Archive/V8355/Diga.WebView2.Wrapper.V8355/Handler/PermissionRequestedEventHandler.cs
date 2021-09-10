using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class PermissionRequestedEventHandler : IWebView2PermissionRequestedEventHandler
    {
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        public void Invoke(IWebView2WebView webview, IWebView2PermissionRequestedEventArgs args)
        {
            OnPermissionRequested(new PermissionRequestedEventArgs(args));
        }

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }
    }
}