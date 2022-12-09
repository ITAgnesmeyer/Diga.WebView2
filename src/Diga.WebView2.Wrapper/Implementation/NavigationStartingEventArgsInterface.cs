using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class NavigationStartingEventArgsInterface : EventArgs
    {
        private ComObjectHolder< ICoreWebView2NavigationStartingEventArgs> _args;
        public NavigationStartingEventArgsInterface(ICoreWebView2NavigationStartingEventArgs args)
        {
            this.Args = args;
        }

        private ICoreWebView2NavigationStartingEventArgs Args
        {
            get
            {
                if (this._args == null)
                {
                    Debug.Print(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");

                    throw new InvalidOperationException(nameof(NavigationStartingEventArgsInterface) + "=>" + nameof(this.Args) + " is null");
                }

                return this._args.Interface;
            }
            set => this._args = new ComObjectHolder<ICoreWebView2NavigationStartingEventArgs>(value);
        }
        public string uri => this.Args.uri;

        public int IsUserInitiated => this.Args.IsUserInitiated;

        public int IsRedirected => this.Args.IsRedirected;

        public ICoreWebView2HttpRequestHeaders RequestHeaders => this.Args.RequestHeaders;

        public int Cancel { get => this.Args.Cancel; set => this.Args.Cancel = value; }

        public ulong NavigationId => this.Args.NavigationId;
    }
}