using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Handler;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public partial class WebView2Environment : ICoreWebView2Environment4
    {
        private ICoreWebView2Environment4 _Interface;

        ICoreWebView2WebResourceResponse ICoreWebView2Environment.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment) this._Interface).CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment2.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment2) this._Interface).CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment3.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment4.CreateWebResourceResponse(IStream Content, int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return this._Interface.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        void ICoreWebView2Environment.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment4.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment4.CreateWebResourceRequest(string uri, string Method, IStream postData, string Headers)
        {
            return this._Interface.CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        void ICoreWebView2Environment4.CreateCoreWebView2CompositionController(IntPtr ParentWindow,
            ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            this._Interface.CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment4.CreateCoreWebView2PointerInfo()
        {
            return this._Interface.CreateCoreWebView2PointerInfo();
        }

        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return this._Interface.GetProviderForHwnd(hwnd);
        }

        void ICoreWebView2Environment4.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment3.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment3) this._Interface).remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment3.CreateWebResourceRequest(string uri, string Method, IStream postData, string Headers)
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        void ICoreWebView2Environment3.CreateCoreWebView2CompositionController(IntPtr ParentWindow,
            ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            ((ICoreWebView2Environment3) this._Interface).CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment3.CreateCoreWebView2PointerInfo()
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateCoreWebView2PointerInfo();
        }

        void ICoreWebView2Environment3.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment3) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment2.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment2) this._Interface).remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment2.CreateWebResourceRequest(string uri, string Method, IStream postData, string Headers)
        {
            return ((ICoreWebView2Environment2) this._Interface).CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        void ICoreWebView2Environment2.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment2) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment) this._Interface).remove_NewBrowserVersionAvailable(token);
        }
    }

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
            this.ToInterface().remove_NewBrowserVersionAvailable(this._NewBrowserVersionAvailableToken);
        }
        private void OnNewBrowserVersionAvailableInternal(object sender, WebView2EventArgs e)
        {
            OnNewBrowserVersionAvailable(e);
        }


        //void ICoreWebView2Environment.CreateCoreWebView2Controller(IntPtr parentWindow,
        //    ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        //{
        //    this._Interface.CreateCoreWebView2Controller(parentWindow, handler);
        //}


        //ICoreWebView2WebResourceResponse ICoreWebView2Environment4.CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase,
        //    string headers)
        //{
        //    return this._Interface.CreateWebResourceResponse(content, statusCode, reasonPhrase, headers);
        //}

        public ICoreWebView2WebResourceResponse CreateWebResourceResponse(IStream content, int statusCode, string reasonPhrase, string headers)
        {
            return this.ToInterface().CreateWebResourceResponse(content, statusCode, reasonPhrase, headers);
        }

        public string BrowserVersionString => this.ToInterface().BrowserVersionString;



        //string ICoreWebView2Environment4.BrowserVersionString => this._Interface.BrowserVersionString;
        //void ICoreWebView2Environment4.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
        //    out EventRegistrationToken token)
        //{
        //    this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        //}

        //void ICoreWebView2Environment4.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        //{
        //    this._Interface.remove_NewBrowserVersionAvailable(token);
        //}


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
    }
}