using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NavigationStartingEventArgsInterface : EventArgs, ICoreWebView2NavigationStartingEventArgs
    {
        private ICoreWebView2NavigationStartingEventArgs _args;
        public NavigationStartingEventArgsInterface(ICoreWebView2NavigationStartingEventArgs args)
        {
            this._args = args;
        }

        public string uri => _args.uri;

        public int IsUserInitiated => _args.IsUserInitiated;

        public int IsRedirected => _args.IsRedirected;

        public ICoreWebView2HttpRequestHeaders RequestHeaders => _args.RequestHeaders;

        public int Cancel { get => _args.Cancel; set => _args.Cancel = value; }

        public ulong NavigationId => _args.NavigationId;
    }

    public class NavigationStartingEventArgs : NavigationStartingEventArgsInterface
    {

        public NavigationStartingEventArgs(ICoreWebView2NavigationStartingEventArgs args) : base(args)
        {
        }

        new public bool IsUserInitiated => (CBOOL)base.IsUserInitiated;


        new public bool IsRedirected => (CBOOL)base.IsRedirected;


        new public bool Cancel
        {
            get => (CBOOL)base.Cancel;
            set => base.Cancel = (CBOOL)value;
        }

    }
}