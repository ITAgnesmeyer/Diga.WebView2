using System;
using System.Diagnostics;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContextMenuRequestedEventHandler : ICoreWebView2ContextMenuRequestedEventHandler
    {
        public event EventHandler<ContextMenuRequestedEventArgs> ContextMenuRequested;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2ContextMenuRequestedEventArgs args)
        {
            try
            {
                OnContextMenuRequested(new ContextMenuRequestedEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ContextMenuRequestedEventHandler) + " Exception:" + ex.ToString());
            }
            
        }

        protected virtual void OnContextMenuRequested(ContextMenuRequestedEventArgs e)
        {
            ContextMenuRequested?.Invoke(this, e);
        }
    }
}