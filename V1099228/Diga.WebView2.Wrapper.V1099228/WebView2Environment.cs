using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
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
        public event EventHandler<BrowserProcessExitedEventArgs> BrowserProcessExited;
        private EventRegistrationToken _NewBrowserVersionAvailableToken;
        private EventRegistrationToken _BrowserProcessExitedToken;


        public WebView2Environment(ICoreWebView2Environment5 iface)
        {
            this._Interface = iface;
            this.RegisterEvents();
        }

        private ICoreWebView2Environment5 ToInterface()
        {
            return _Interface;
        }

        public WebView2PointerInfo CreateCoreWebView2PointerInfo()
        {
            return new WebView2PointerInfo(this._Interface.CreateCoreWebView2PointerInfo());
        }

        private void RegisterEvents()
        {
            //add_NewBrowserVersionAvailable

            NewBrowserVersionAvailableEventHandler newBrowserVersionAvailableHandler = new NewBrowserVersionAvailableEventHandler();
            newBrowserVersionAvailableHandler.NewBrowserVersionAvailable += OnNewBrowserVersionAvailableInternal;
            this.ToInterface().add_NewBrowserVersionAvailable(newBrowserVersionAvailableHandler,
                out this._NewBrowserVersionAvailableToken);
            BrowserProcessExitedEventHandler browserProcessExitedEventHandler = new BrowserProcessExitedEventHandler();
            browserProcessExitedEventHandler.BrowserProcessExited += OnBrowserProcessExitedIntern;
            this.ToInterface()
                .add_BrowserProcessExited(browserProcessExitedEventHandler, out this._BrowserProcessExitedToken);
        }

        private void OnBrowserProcessExitedIntern(object sender, BrowserProcessExitedEventArgs e)
        {
            OnBrowserProcessExited(e);
        }

        [HandleProcessCorruptedStateExceptions]
        private void UnRegisterEvents()
        {   
            if(this._Interface == null) return;
            try
            {
                EventRegistrationTool.UnWireToken(this._NewBrowserVersionAvailableToken,  this.ToInterface().remove_NewBrowserVersionAvailable);
                EventRegistrationTool.UnWireToken(this._BrowserProcessExitedToken,this.ToInterface().remove_BrowserProcessExited);
            }
            catch (Exception exception)
            {
                Debug.Print(exception.ToString());
            }
            
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
            this.UnRegisterEvents();
            this._Interface = null;
        }

        public void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            _Interface.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        public void CreateCoreWebView2CompositionController(IntPtr ParentWindow,
            [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2CompositionControllerCompletedHandler handler)
        {
            this._Interface.CreateCoreWebView2CompositionController(ParentWindow, handler);
        }

        public object GetProviderForHwnd(IntPtr hwnd)
        {
            return this._Interface.GetProviderForHwnd(hwnd);
        }

        protected virtual void OnBrowserProcessExited(BrowserProcessExitedEventArgs e)
        {
            BrowserProcessExited?.Invoke(this, e);
        }
    }
}