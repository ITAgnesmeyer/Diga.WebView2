using Diga.WebView2.Interop;
using System;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2Environment : ICoreWebView2Environment5
    {
        private ICoreWebView2Environment5 _Interface;

        ICoreWebView2WebResourceResponse ICoreWebView2Environment.CreateWebResourceResponse(IStream Content,
            int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment) this._Interface).CreateWebResourceResponse(Content, StatusCode,
                ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment2.CreateWebResourceResponse(IStream Content,
            int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment2) this._Interface).CreateWebResourceResponse(Content, StatusCode,
                ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment3.CreateWebResourceResponse(IStream Content,
            int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateWebResourceResponse(Content, StatusCode,
                ReasonPhrase, Headers);
        }

        ICoreWebView2WebResourceResponse ICoreWebView2Environment4.CreateWebResourceResponse(IStream Content,
            int StatusCode, string ReasonPhrase,
            string Headers)
        {
            return this._Interface.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        void ICoreWebView2Environment.add_NewBrowserVersionAvailable(
            ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment5.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment5.CreateWebResourceRequest(string uri, string Method, IStream postData, string Headers)
        {
            return this._Interface.CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        void ICoreWebView2Environment5.add_NewBrowserVersionAvailable(ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment4.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            this._Interface.remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment4.CreateWebResourceRequest(string uri, string Method,
            IStream postData, string Headers)
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

        void ICoreWebView2Environment5.add_BrowserProcessExited(ICoreWebView2BrowserProcessExitedEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_BrowserProcessExited(eventHandler, out token);
        }

        void ICoreWebView2Environment5.remove_BrowserProcessExited(EventRegistrationToken token)
        {
            this._Interface.remove_BrowserProcessExited(token);
        }


        void ICoreWebView2Environment4.add_NewBrowserVersionAvailable(
            ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            this._Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment3.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment3) this._Interface).remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment3.CreateWebResourceRequest(string uri, string Method,
            IStream postData, string Headers)
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateWebResourceRequest(uri, Method, postData,
                Headers);
        }

        void ICoreWebView2Environment3.CreateCoreWebView2CompositionController(IntPtr ParentWindow,
            ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            ((ICoreWebView2Environment3) this._Interface)
                .CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment3.CreateCoreWebView2PointerInfo()
        {
            return ((ICoreWebView2Environment3) this._Interface).CreateCoreWebView2PointerInfo();
        }

        void ICoreWebView2Environment3.add_NewBrowserVersionAvailable(
            ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment3) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment2.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment2) this._Interface).remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2WebResourceRequest ICoreWebView2Environment2.CreateWebResourceRequest(string uri, string Method,
            IStream postData, string Headers)
        {
            return ((ICoreWebView2Environment2) this._Interface).CreateWebResourceRequest(uri, Method, postData,
                Headers);
        }

        void ICoreWebView2Environment2.add_NewBrowserVersionAvailable(
            ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler,
            out EventRegistrationToken token)
        {
            ((ICoreWebView2Environment2) this._Interface).add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        void ICoreWebView2Environment.remove_NewBrowserVersionAvailable(EventRegistrationToken token)
        {
            ((ICoreWebView2Environment) this._Interface).remove_NewBrowserVersionAvailable(token);
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment5.CreateCoreWebView2PointerInfo()
        {
            return this._Interface.CreateCoreWebView2PointerInfo();
        }
    }
}