using System;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment : ICoreWebView2Environment
    {
        private ICoreWebView2Environment _Interface;

        public WebView2Environment(ICoreWebView2Environment iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2Environment ToInterface()
        {
            return this;
        }

        public void CreateCoreWebView2Host(IntPtr ParentWindow,
            ICoreWebView2CreateCoreWebView2HostCompletedHandler handler)
        {
            this.ToInterface().CreateCoreWebView2Host(ParentWindow, handler);
        }


        public ICoreWebView2WebResourceResponse CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers)
        {
            return  this.ToInterface().CreateWebResourceResponse(content, statusCode, reasonPhrase, headers); }


        void ICoreWebView2Environment.CreateCoreWebView2Host(IntPtr ParentWindow, ICoreWebView2CreateCoreWebView2HostCompletedHandler handler)
        {
            this._Interface.CreateCoreWebView2Host(ParentWindow, handler);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return this._Interface.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        string ICoreWebView2Environment.BrowserVersionInfo => this._Interface.BrowserVersionInfo;

        void ICoreWebView2Environment.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewBrowserVersionAvailable(token);
        }
    }
}