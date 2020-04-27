using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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