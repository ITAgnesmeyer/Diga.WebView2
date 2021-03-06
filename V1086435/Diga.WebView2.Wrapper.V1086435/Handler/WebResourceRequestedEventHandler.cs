﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class WebResourceRequestedEventHandler : ICoreWebView2WebResourceRequestedEventHandler
    {
        public event EventHandler<WebResourceRequestedEventArgs> WebResourceRequested;
        
        protected virtual void OnWebResourceRequested(WebResourceRequestedEventArgs e)
        {
            WebResourceRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2WebResourceRequestedEventArgs args)
        {
            OnWebResourceRequested(new WebResourceRequestedEventArgs(args));
        }
    }
}