using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper.Implementation
{

    public class WebView2EnvironmentInterface : ICoreWebView2Environment, IDisposable
    {
        private ICoreWebView2Environment _Environment;
        private bool _IsDisposed;
        private ICoreWebView2Environment Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2EnvironmentInterface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2EnvironmentInterface) + "." + nameof(Environment) + " is null");

                }
                return _Environment;
            }
            set { _Environment = value; }
        }
        public WebView2EnvironmentInterface(ICoreWebView2Environment environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));
            Environment = environment;
        }
        public void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            Environment.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceResponse CreateWebResourceResponse([In, MarshalAs(UnmanagedType.Interface)] IStream Content, [In] int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return Environment.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        public string BrowserVersionString => _Environment.BrowserVersionString;

        public void add_NewBrowserVersionAvailable([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            Environment.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        public void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token)
        {
            Environment.remove_NewBrowserVersionAvailable(token);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_IsDisposed)
            {
                if (disposing)
                {
                    _Environment = null;
                }

                _IsDisposed = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}