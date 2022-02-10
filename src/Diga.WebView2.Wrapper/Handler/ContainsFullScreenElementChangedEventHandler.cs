using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContainsFullScreenElementChangedEventHandler : ICoreWebView2ContainsFullScreenElementChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> ContainsFullScreenElementChanged;

        public void Invoke(ICoreWebView2 sender, object args)
        {
            try
            {
                OnContainsFullScreenElementChanged(new WebView2EventArgs(sender, args));
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(ContainsFullScreenElementChangedEventHandler) + " Exception:" + ex.ToString());
            }


        }

        protected virtual void OnContainsFullScreenElementChanged(WebView2EventArgs e)
        {
            ContainsFullScreenElementChanged?.Invoke(this, e);
        }

    }
}