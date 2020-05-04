using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class PermissionRequestedEventHandler : ICoreWebView2PermissionRequestedEventHandler
    {
        public event EventHandler<PermissionRequestedEventArgs> PermissionRequested;
        

        protected virtual void OnPermissionRequested(PermissionRequestedEventArgs e)
        {
            PermissionRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2PermissionRequestedEventArgs args)
        {
            OnPermissionRequested(new PermissionRequestedEventArgs(args));
        }
    }
}