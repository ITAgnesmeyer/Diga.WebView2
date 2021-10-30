using Diga.WebView2.Interop;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Wrapper
{

    public  class WebView2EnvironmentInterface : ICoreWebView2Environment ,IDisposable
    {
        private  ICoreWebView2Environment _Environment;
        private bool disposedValue;

        public WebView2EnvironmentInterface(ICoreWebView2Environment environment)
        {
            this._Environment = environment;
        }
        public void CreateCoreWebView2Controller(IntPtr ParentWindow, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2CreateCoreWebView2ControllerCompletedHandler handler)
        {
            _Environment.CreateCoreWebView2Controller(ParentWindow, handler);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2WebResourceResponse CreateWebResourceResponse([In, MarshalAs(UnmanagedType.Interface)] IStream Content, [In] int StatusCode, [In, MarshalAs(UnmanagedType.LPWStr)] string ReasonPhrase, [In, MarshalAs(UnmanagedType.LPWStr)] string Headers)
        {
            return _Environment.CreateWebResourceResponse(Content, StatusCode, ReasonPhrase, Headers);
        }

        public string BrowserVersionString => _Environment.BrowserVersionString;

        public void add_NewBrowserVersionAvailable([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NewBrowserVersionAvailableEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Environment.add_NewBrowserVersionAvailable(eventHandler, out token);
        }

        public void remove_NewBrowserVersionAvailable([In] EventRegistrationToken token)
        {
            _Environment.remove_NewBrowserVersionAvailable(token);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._Environment = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2EnvironmentInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}