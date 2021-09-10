using System;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment : ICoreWebView2Environment,IDisposable
    {
        public event EventHandler<WebView2EventArgs> NewBrowserVersionAvailable;
        private ICoreWebView2Environment _Interface;
        private EventRegistrationToken _NewBrowserVersionAvailableToken;

        public WebView2Environment(ICoreWebView2Environment iface)
        {
            this._Interface = iface;
            this.RegisterEvents();
        }

        private ICoreWebView2Environment ToInterface()
        {
            return this;
        }

        private void RegisterEvents()
        {
            //add_NewBrowserVersionAvailable

            NewBrowserVersionAvailableEventHandler newBrowserVersionAvailableHandler = new NewBrowserVersionAvailableEventHandler();
            newBrowserVersionAvailableHandler.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableInternal;
            this.ToInterface().add_NewBrowserVersionAvailable(newBrowserVersionAvailableHandler,
                out this._NewBrowserVersionAvailableToken);
        }

        private void UnregisterEvents()
        {
            this.ToInterface().remove_NewBrowserVersionAvailable(this._NewBrowserVersionAvailableToken);
        }
        private void OnNewBrowserVersionAvailableInternal(object sender, WebView2EventArgs e)
        {
            OnNewBrowserVersionAvailable(e);
        }

        public void CreateCoreWebView2Controller(IntPtr parentWindow,
            ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            this.ToInterface().CreateCoreWebView2Controller(parentWindow, handler);
        }
        void ICoreWebView2Environment.CreateCoreWebView2Controller(IntPtr parentWindow,
            ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            this._Interface.CreateCoreWebView2Controller(parentWindow, handler);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment.CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase,
            string headers)
        {
            return this._Interface.CreateWebResourceResponse(content, statusCode, reasonPhrase, headers);
        }

        public ICoreWebView2WebResourceResponse CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers)
        {
            return  this.ToInterface().CreateWebResourceResponse(content, statusCode, reasonPhrase, headers);
        }

        public string BrowserVersionString => this.ToInterface().BrowserVersionString;



        string ICoreWebView2Environment.BrowserVersionString => this._Interface.BrowserVersionString;
        void ICoreWebView2Environment.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewBrowserVersionAvailable(token);
        }


        protected virtual void OnNewBrowserVersionAvailable(WebView2EventArgs e)
        {
            NewBrowserVersionAvailable?.Invoke(this, e);
        }

        public void Dispose()
        {
            this.UnregisterEvents();
            this._Interface = null;
        }
    }
}