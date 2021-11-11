using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ZoomFactorChangedEventHandler : ICoreWebView2ZoomFactorChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
        public void Invoke(ICoreWebView2Controller sender, object args)
        {
            try
            {
                OnZoomFactorChanged(new WebView2EventArgs(sender, args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(ZoomFactorChangedEventHandler) + " Exception:" + ex.ToString());
                
            }

            
        }

        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }


    }
}