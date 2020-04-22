using System;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.EventArguments
{

    public class WebViewEnvironment : IWebView2Environment3
    {
        private IWebView2Environment3 _Interface;

        public WebViewEnvironment(IWebView2Environment3 iface)
        {
            this._Interface = iface;
        }

        private IWebView2Environment3 ToInterface()
        {
            return this;
        }

        public void CreateWebView(IntPtr parentWindow, IWebView2CreateWebViewCompletedHandler handler)
        {
            this.ToInterface().CreateWebView(parentWindow, handler);
        }

        public void CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers,
            ref IWebView2WebResourceResponse response)
        {
            this.ToInterface().CreateWebResourceResponse(content, statusCode, reasonPhrase, headers, ref response);
        }

        public string BrowserVersionInfo => this.ToInterface().BrowserVersionInfo;
        void IWebView2Environment.CreateWebView(IntPtr parentWindow, IWebView2CreateWebViewCompletedHandler handler)
        {
            ((IWebView2Environment) this._Interface).CreateWebView(parentWindow, handler);
        }

        void IWebView2Environment3.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase, string Headers,
            ref IWebView2WebResourceResponse Response)
        {
            this._Interface.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers, ref Response);
        }

        string IWebView2Environment3.BrowserVersionInfo => this._Interface.BrowserVersionInfo;

        void IWebView2Environment3.add_NewVersionAvailable(IWebView2NewVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            this._Interface.add_NewVersionAvailable(eventHandler, out token);
        }

        void IWebView2Environment3.remove_NewVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewVersionAvailable(token);
        }

        void IWebView2Environment3.CreateWebView(IntPtr parentWindow, IWebView2CreateWebViewCompletedHandler handler)
        {
            this._Interface.CreateWebView(parentWindow, handler);
        }

        void IWebView2Environment2.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase, string Headers,
            ref IWebView2WebResourceResponse Response)
        {
            ((IWebView2Environment2) this._Interface).CreateWebResourceResponse(Content, StatusCode, ReasonPhrase,
                Headers, ref Response);
        }

        string IWebView2Environment2.BrowserVersionInfo => ((IWebView2Environment2)this._Interface).BrowserVersionInfo;

        void IWebView2Environment2.CreateWebView(IntPtr parentWindow, IWebView2CreateWebViewCompletedHandler handler)
        {
            ((IWebView2Environment2) this._Interface).CreateWebView(parentWindow, handler);
        }

        void IWebView2Environment.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase, string Headers,
            ref IWebView2WebResourceResponse Response)
        {
            ((IWebView2Environment) this._Interface).CreateWebResourceResponse(Content, StatusCode, ReasonPhrase,
                Headers, ref Response);
        }
    }

    public class EnvironmentCompletedHandlerArgs : System.EventArgs
    {
        public EnvironmentCompletedHandlerArgs(IWebView2Environment3 environment)
        {
            this.Environment = new WebViewEnvironment( environment);
        }

        public WebViewEnvironment Environment{get;}

    }
}