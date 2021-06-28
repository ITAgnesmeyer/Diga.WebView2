using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
   

    public partial class WebView2Environment : IDisposable
    {
        public event EventHandler<WebView2EventArgs> NewBrowserVersionAvailable;
        
        private EventRegistrationToken _NewBrowserVersionAvailableToken;
        

        public WebView2Environment(ICoreWebView2Environment4 iface)
        {
            this._Interface = iface;
            this.RegisterEvents();
        }

        private ICoreWebView2Environment4 ToInterface()
        {
            return _Interface;
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
            if(this._Interface == null) return;

            this.ToInterface().remove_NewBrowserVersionAvailable(this._NewBrowserVersionAvailableToken);
        }
        private void OnNewBrowserVersionAvailableInternal(object sender, WebView2EventArgs e)
        {
            OnNewBrowserVersionAvailable(e);
        }

        public ICoreWebView2WebResourceResponse CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers)
        {
            return this.ToInterface().CreateWebResourceResponse(content, statusCode, reasonPhrase, headers);
        }

        public string BrowserVersionString => this.ToInterface().BrowserVersionString;

        protected virtual void OnNewBrowserVersionAvailable(WebView2EventArgs e)
        {
            NewBrowserVersionAvailable?.Invoke(this, e);
        }

        public void Dispose()
        {
            this.UnregisterEvents();
            this._Interface = null;
        }

        public void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            _Interface.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return this._Interface.GetProviderForHwnd(hwnd);
        }
    }
}