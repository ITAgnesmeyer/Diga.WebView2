﻿using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class NavigationStartingEventArgs : EventArgs, ICoreWebView2NavigationStartingEventArgs
    {
        string ICoreWebView2NavigationStartingEventArgs.uri => this._args.uri;
        public string Uri => ((ICoreWebView2NavigationStartingEventArgs) this).uri;
        int ICoreWebView2NavigationStartingEventArgs.IsUserInitiated => this._args.IsUserInitiated;
        public bool IsUserInitiated => new BOOL(((ICoreWebView2NavigationStartingEventArgs) this).IsUserInitiated);
        int ICoreWebView2NavigationStartingEventArgs.IsRedirected => this._args.IsRedirected;

        public bool IsRedirected => new BOOL(((ICoreWebView2NavigationStartingEventArgs) this).IsRedirected);

        ICoreWebView2HttpRequestHeaders ICoreWebView2NavigationStartingEventArgs.RequestHeaders => this._args.RequestHeaders;

        int ICoreWebView2NavigationStartingEventArgs.Cancel
        {
            get => this._args.Cancel;
            set => this._args.Cancel = value;
        }

        public bool Cancel
        {
            get => new BOOL(((ICoreWebView2NavigationStartingEventArgs) this).Cancel);
            set => ((ICoreWebView2NavigationStartingEventArgs) this).Cancel = new BOOL(value);
        }
        ulong ICoreWebView2NavigationStartingEventArgs.NavigationId => throw new NotImplementedException();

        private ICoreWebView2NavigationStartingEventArgs _args;

        public NavigationStartingEventArgs(ICoreWebView2NavigationStartingEventArgs args)
        {
            this._args = args;
        }
    }
}