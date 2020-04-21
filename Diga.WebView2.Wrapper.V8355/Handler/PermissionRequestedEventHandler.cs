using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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