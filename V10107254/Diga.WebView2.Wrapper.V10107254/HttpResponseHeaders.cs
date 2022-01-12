using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class HttpResponseHeaders : ICoreWebView2HttpResponseHeaders,IDisposable
    {
        private  ICoreWebView2HttpResponseHeaders _Interface;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        private bool disposedValue;

        public HttpResponseHeaders(ICoreWebView2HttpResponseHeaders iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2HttpResponseHeaders ToInterface()
        {
            return _Interface;
        }

        public void AppendHeader(string name, string value)
        {
            this.ToInterface().AppendHeader(name, value);
        }

        public bool Contains(string name)
        {
            int contians = this.ToInterface().Contains(name);
            return new CBOOL(contians);
        }

        public HttpHeadersCollectionIterator GetHeaders(string name)
        {
            var iterator = this.ToInterface().GetHeaders(name);
            return new HttpHeadersCollectionIterator(iterator);
        }
        public HttpHeadersCollectionIterator GetIterator()
        {
            var iterator = this.ToInterface().GetIterator();
            return new HttpHeadersCollectionIterator(iterator);
        }

        void ICoreWebView2HttpResponseHeaders.AppendHeader(string name, string value)
        {
            this._Interface.AppendHeader(name, value);
        }

        int ICoreWebView2HttpResponseHeaders.Contains(string name)
        {
            return this._Interface.Contains(name);
        }

        string ICoreWebView2HttpResponseHeaders.GetHeader(string name)
        {
            return this._Interface.GetHeader(name);
        }

        ICoreWebView2HttpHeadersCollectionIterator ICoreWebView2HttpResponseHeaders.GetHeaders(string name)
        {
            return this._Interface.GetHeaders(name);
        }

        ICoreWebView2HttpHeadersCollectionIterator ICoreWebView2HttpResponseHeaders.GetIterator()
        {
            return this._Interface.GetIterator();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                }

                this._Interface = null;
                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~HttpResponseHeaders()
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