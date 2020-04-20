using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class NavigationStartingEventArgs : EventArgs, IWebView2NavigationStartingEventArgs
    {
        string IWebView2NavigationStartingEventArgs.uri => this._args.uri;
        public string Uri => ((IWebView2NavigationStartingEventArgs) this).uri;
        int IWebView2NavigationStartingEventArgs.IsUserInitiated => this._args.IsUserInitiated;
        public bool IsUserInitiated => new CBOOL(((IWebView2NavigationStartingEventArgs) this).IsUserInitiated);
        int IWebView2NavigationStartingEventArgs.IsRedirected => this._args.IsRedirected;

        public bool IsRedirected => new CBOOL(((IWebView2NavigationStartingEventArgs) this).IsRedirected);

        IWebView2HttpRequestHeaders IWebView2NavigationStartingEventArgs.RequestHeaders => this._args.RequestHeaders;

        int IWebView2NavigationStartingEventArgs.Cancel
        {
            get => this._args.Cancel;
            set => this._args.Cancel = value;
        }

        public bool Cancel
        {
            get => new CBOOL(((IWebView2NavigationStartingEventArgs) this).Cancel);
            set => ((IWebView2NavigationStartingEventArgs) this).Cancel = new CBOOL(value);
        }
        //ulong IWebView2NavigationStartingEventArgs.NavigationId => throw new NotImplementedException();

        private IWebView2NavigationStartingEventArgs _args;

        public NavigationStartingEventArgs(IWebView2NavigationStartingEventArgs args)
        {
            this._args = args;
        }
    }
}