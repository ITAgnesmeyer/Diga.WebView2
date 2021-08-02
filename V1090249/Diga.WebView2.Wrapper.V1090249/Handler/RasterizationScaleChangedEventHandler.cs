using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class RasterizationScaleChangedEventHandler : ICoreWebView2RasterizationScaleChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> RasteriazationScaleChanged; 
        public void Invoke(ICoreWebView2Controller sender, object args)
        {
            OnRasteriazationScaleChanged(new WebView2EventArgs(sender, args));
        }

        protected virtual void OnRasteriazationScaleChanged(WebView2EventArgs e)
        {
            RasteriazationScaleChanged?.Invoke(this, e);
        }
    }
}