using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class ProcessFailedEventArgs : EventArgs, IWebView2ProcessFailedEventArgs
    {
        private IWebView2ProcessFailedEventArgs _Args;

        public ProcessFailedEventArgs(IWebView2ProcessFailedEventArgs args)
        {
            this._Args = args;
        }

        public ProcessFailedKind ProcessFailedKind => (ProcessFailedKind) this._Args.ProcessFailedKind;

        WEBVIEW2_PROCESS_FAILED_KIND IWebView2ProcessFailedEventArgs.ProcessFailedKind
        {
            get => this._Args.ProcessFailedKind;

        }
    }
}