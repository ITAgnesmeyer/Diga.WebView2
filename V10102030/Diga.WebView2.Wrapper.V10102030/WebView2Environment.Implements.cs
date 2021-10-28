using Diga.WebView2.Interop;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{
    public partial class WebView2Environment : ICoreWebView2Environment6
    {
        private ICoreWebView2Environment6 _Interface;

        public void add_NewBrowserVersionAvailable([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Interface.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        public void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token)
        {
            _Interface.remove_NewBrowserVersionAvailable(token);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceRequest CreateWebResourceRequest([In, MarshalAs(UnmanagedType.LPWStr)] string uri, [In, MarshalAs(UnmanagedType.LPWStr)] string Method, [In, MarshalAs(UnmanagedType.Interface)] IStream postData, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return _Interface.CreateWebResourceRequest(uri, Method, postData, Headers);
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment6.CreateCoreWebView2PointerInfo()
        {
            return _Interface.CreateCoreWebView2PointerInfo();
        }

        public void add_BrowserProcessExited([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Interface.add_BrowserProcessExited(eventHandler, out token);
        }

        public void remove_BrowserProcessExited([In] EventRegistrationToken token)
        {
            _Interface.remove_BrowserProcessExited(token);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2PrintSettings CreatePrintSettings()
        {
            return _Interface.CreatePrintSettings();
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment5.CreateCoreWebView2PointerInfo()
        {
            return ((ICoreWebView2Environment5)_Interface).CreateCoreWebView2PointerInfo();
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment4.CreateCoreWebView2PointerInfo()
        {
            return ((ICoreWebView2Environment4)_Interface).CreateCoreWebView2PointerInfo();
        }

        ICoreWebView2PointerInfo ICoreWebView2Environment3.CreateCoreWebView2PointerInfo()
        {
            return ((ICoreWebView2Environment3)_Interface).CreateCoreWebView2PointerInfo();
        }
    }
}