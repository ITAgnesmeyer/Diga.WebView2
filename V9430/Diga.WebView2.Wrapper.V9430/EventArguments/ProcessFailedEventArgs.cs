﻿using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ProcessFailedEventArgs : EventArgs, ICoreWebView2ProcessFailedEventArgs
    {
        private ICoreWebView2ProcessFailedEventArgs _Args;

        public ProcessFailedEventArgs(ICoreWebView2ProcessFailedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2ProcessFailedEventArgs ToInterface()
        {
            return this;
        }
        public ProcessFailedKind ProcessFailedKind => (ProcessFailedKind)this.ToInterface().ProcessFailedKind;

#if V9488
        COREWEBVIEW2_PROCESS_FAILED_KIND ICoreWebView2ProcessFailedEventArgs.ProcessFailedKind => this._Args.ProcessFailedKind;
#else

        CORE_WEBVIEW2_PROCESS_FAILED_KIND ICoreWebView2ProcessFailedEventArgs.ProcessFailedKind => this._Args.ProcessFailedKind;
#endif
    }
}