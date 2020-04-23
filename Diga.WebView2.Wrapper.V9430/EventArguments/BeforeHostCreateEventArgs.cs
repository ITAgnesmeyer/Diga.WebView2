﻿using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class BeforeHostCreateEventArgs : System.EventArgs
    {
        public BeforeHostCreateEventArgs(ICoreWebView2 webView, ICoreWebView2Host host, ICoreWebView2Settings settings)
        {
            this.WebView = webView;
            this.Host = host;
            this.Settings = settings;
        }

        public ICoreWebView2 WebView{get;}
        public ICoreWebView2Host Host{get;}
        public ICoreWebView2Settings Settings{get;}

    }
}