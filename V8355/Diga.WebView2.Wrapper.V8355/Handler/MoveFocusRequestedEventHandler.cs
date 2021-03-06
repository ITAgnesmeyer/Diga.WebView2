﻿using Diga.WebView2.Interop;
using System;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class MoveFocusRequestedEventHandler : IWebView2MoveFocusRequestedEventHandler
    {
        public event EventHandler<MoveFocusRequestedEventArgs> MoveFocusRequested;
        public void Invoke(IWebView2WebView webview, IWebView2MoveFocusRequestedEventArgs args)
        {
            OnMoveFocusRequested(new MoveFocusRequestedEventArgs(args));
        }

        protected virtual void OnMoveFocusRequested(MoveFocusRequestedEventArgs e)
        {
            MoveFocusRequested?.Invoke(this, e);
        }
    }
}