using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class IsMutedChangedEventHandler : ICoreWebView2IsMutedChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> IsMutedChanged;
        public void Invoke(ICoreWebView2 sender, object args)
        {
            try
            {
                OnIsMutedChanged(new WebView2EventArgs(sender, args));
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(IsMutedChangedEventHandler) + " Exception:" + ex.ToString());
            }
        }

        protected virtual void OnIsMutedChanged(WebView2EventArgs e)
        {
            IsMutedChanged?.Invoke(this, e);
        }
    }
}