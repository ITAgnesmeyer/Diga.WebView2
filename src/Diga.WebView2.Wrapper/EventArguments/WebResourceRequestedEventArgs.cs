using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class WebResourceRequestedEventArgs : EventArgs, ICoreWebView2WebResourceRequestedEventArgs,IDisposable
    {
        private ICoreWebView2WebResourceRequestedEventArgs _Args;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public WebResourceRequestedEventArgs(ICoreWebView2WebResourceRequestedEventArgs args)
        {
            this._Args = args;
        }

        private ICoreWebView2WebResourceRequestedEventArgs ToInterface()
        {
            return _Args;
        }

        public WebResourceRequest Request => new WebResourceRequest(this.ToInterface().Request);

        public WebResourceResponse Response
        {
            get
            {
                if (this.ToInterface().Response == null)
                    return null;
                return new WebResourceResponse(this.ToInterface().Response);
            }
            set
            {
                this.ToInterface().Response = value;
            }
        }

        ICoreWebView2WebResourceRequest ICoreWebView2WebResourceRequestedEventArgs.Request => this._Args.Request;

        ICoreWebView2WebResourceResponse ICoreWebView2WebResourceRequestedEventArgs.Response
        {
            get => this._Args.Response;
            set => this._Args.Response = value;
        }

        public WebView2Deferral GetDeferral()
        {
            return new WebView2Deferral(this._Args.GetDeferral());
        }

        ICoreWebView2Deferral ICoreWebView2WebResourceRequestedEventArgs.GetDeferral()
        {
            return this._Args.GetDeferral();
        }
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT ICoreWebView2WebResourceRequestedEventArgs.ResourceContext => this._Args.ResourceContext;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: Verwalteten Zustand (verwaltete Objekte) bereinigen
                    this.handle.Dispose();
                }

                this._Args = null;
                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        ~WebResourceRequestedEventArgs()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}