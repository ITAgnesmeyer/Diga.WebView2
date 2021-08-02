﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class ContentLoadingEventHandler : ICoreWebView2ContentLoadingEventHandler
    {
        public event EventHandler<ContentLoadingEventArgs> ContentLoading;
        public void Invoke(ICoreWebView2 webview, ICoreWebView2ContentLoadingEventArgs args)
        {
            OnContentLoading(new ContentLoadingEventArgs(new CBOOL(args.IsErrorPage), args.NavigationId));
        }

        protected virtual void OnContentLoading(ContentLoadingEventArgs e)
        {
            ContentLoading?.Invoke(this, e);
        }
    }
}