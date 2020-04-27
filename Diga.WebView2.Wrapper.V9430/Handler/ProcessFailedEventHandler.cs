﻿using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class ProcessFailedEventHandler : ICoreWebView2ProcessFailedEventHandler
    {
        public event EventHandler<ProcessFailedEventArgs> ProcessFailed;
        

        protected virtual void OnProcessFailed(ProcessFailedEventArgs e)
        {
            ProcessFailed?.Invoke(this, e);
        }

        public void Invoke(ICoreWebView2 sender, ICoreWebView2ProcessFailedEventArgs args)
        {
            OnProcessFailed(new ProcessFailedEventArgs(args));
        }
    }
}