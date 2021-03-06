﻿using Diga.WebView2.Interop;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    public class WebResourceRequest : IWebView2WebResourceRequest
    {

        private IWebView2WebResourceRequest _Interface;

        public WebResourceRequest(IWebView2WebResourceRequest iface)
        {
            this._Interface = iface;
        }

        private IWebView2WebResourceRequest ToInterface()
        {
            return this;
        }

        public string Uri => this.ToInterface().uri;

        public string Method
        {
            get => this.ToInterface().Method;
            set => this.ToInterface().Method = value;
        }

        public StreamWrapper Content
        {
            get
            {
                if (this.ToInterface().Content == null) return null;
                return new StreamWrapper(this.ToInterface().Content);
            }
            set
            {

                this.ToInterface().Content = value;
            }
        }

        public HttpRequestHeaders Headers
        {
            get
            {
                if(this.ToInterface().Headers == null) return null;
                return new HttpRequestHeaders(this.ToInterface().Headers);
            }
        }

        string IWebView2WebResourceRequest.uri
        {
            get => this._Interface.uri;
            set => this._Interface.uri = value;
        }

        string IWebView2WebResourceRequest.Method
        {
            get => this._Interface.Method;
            set => this._Interface.Method = value;
        }

        IStream IWebView2WebResourceRequest.Content
        {
            get => this._Interface.Content;
            set => this._Interface.Content = value;
        }

        IWebView2HttpRequestHeaders IWebView2WebResourceRequest.Headers => this._Interface.Headers;
    }
}