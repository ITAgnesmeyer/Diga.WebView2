﻿using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NewWindowRequestedEventHandler : ICoreWebView2NewWindowRequestedEventHandler
    {
        public event EventHandler<NewWindowRequestedEventArgs> NewWindowRequested;

        protected virtual void OnNewWindowRequested(NewWindowRequestedEventArgs e)
        {
            NewWindowRequested?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2NewWindowRequestedEventArgs args)
        {
            OnNewWindowRequested(new NewWindowRequestedEventArgs(args));
        }
    }
}