using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NavigationStartingEventArgsInterface : EventArgs, ICoreWebView2NavigationStartingEventArgs
    {
        private ICoreWebView2NavigationStartingEventArgs _args;
        public NavigationStartingEventArgsInterface(ICoreWebView2NavigationStartingEventArgs args)
        {
            this._args = args;
        }

        public string uri => this._args.uri;

        public int IsUserInitiated => this._args.IsUserInitiated;

        public int IsRedirected => this._args.IsRedirected;

        public ICoreWebView2HttpRequestHeaders RequestHeaders => this._args.RequestHeaders;

        public int Cancel { get => this._args.Cancel; set => this._args.Cancel = value; }

        public ulong NavigationId => this._args.NavigationId;
    }
}