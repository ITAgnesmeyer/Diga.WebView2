﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ZoomFactorChangedEventHandler : ICoreWebView2ZoomFactorChangedEventHandler
    {
        public event EventHandler<WebView2EventArgs> ZoomFactorChanged;
#if V9488
        public void Invoke(ICoreWebView2Controller sender, object args)
        {
            OnZoomFactorChanged(new WebView2EventArgs(sender, args));
        }
#else
        public void Invoke(ICoreWebView2Host sender, object args)
        {
            OnZoomFactorChanged(new WebView2EventArgs(sender, args));
        }
#endif
        protected virtual void OnZoomFactorChanged(WebView2EventArgs e)
        {
            ZoomFactorChanged?.Invoke(this, e);
        }


    }
}