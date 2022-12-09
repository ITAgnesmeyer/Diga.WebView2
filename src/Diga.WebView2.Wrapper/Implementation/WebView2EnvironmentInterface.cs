using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2EnvironmentInterface : IDisposable 
    {
        private ComObjectHolder<ICoreWebView2Environment> _Environment;
        private bool _IsDisposed;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2Environment Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2EnvironmentInterface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2EnvironmentInterface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment>(value);
        }
        public WebView2EnvironmentInterface(ICoreWebView2Environment environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        public void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            this.Environment.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceResponse CreateWebResourceResponse([In, MarshalAs(UnmanagedType.Interface)] IStream Content, [In] int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return this.Environment.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        public string BrowserVersionString => this.Environment.BrowserVersionString;

        public void add_NewBrowserVersionAvailable([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Environment.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        public void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token)
        {
            this.Environment.remove_NewBrowserVersionAvailable(token);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDisposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Environment = null;
                }

                this._IsDisposed = true;
            }
        }



        public void Dispose()
        {
           
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}