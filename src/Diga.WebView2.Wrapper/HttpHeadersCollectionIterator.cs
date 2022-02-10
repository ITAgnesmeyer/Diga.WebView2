using System;
using System.Collections;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper
{
    public class HttpHeadersCollectionIterator :IEnumerator,IEnumerable, ICoreWebView2HttpHeadersCollectionIterator,IDisposable
    {
        private ICoreWebView2HttpHeadersCollectionIterator _Interface;
        private bool disposedValue;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
        public HttpHeadersCollectionIterator(ICoreWebView2HttpHeadersCollectionIterator iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2HttpHeadersCollectionIterator Tointerface()
        {
            return _Interface;
        }

        private IEnumerator ToEnumerator()
        {
            return this;
        }
        

        public bool MoveNext()
        {
            return this.ToEnumerator().MoveNext();
        }

        public HeaderItem Current => (HeaderItem) this.ToEnumerator().Current;

        public bool HasCurrent => new CBOOL(this.Tointerface().HasCurrentHeader);

        void ICoreWebView2HttpHeadersCollectionIterator.GetCurrentHeader(out string name, out string value)
        {
            this._Interface.GetCurrentHeader(out name, out value);
        }



        int ICoreWebView2HttpHeadersCollectionIterator.HasCurrentHeader => this._Interface.HasCurrentHeader;
        bool IEnumerator.MoveNext()
        {
            int hasNext =  this.Tointerface().MoveNext( );
            return new CBOOL(hasNext);
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }

        object IEnumerator.Current
        {
            get
            {
                this.Tointerface().GetCurrentHeader(out string name, out string value);
                return new HeaderItem(name, value);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int ICoreWebView2HttpHeadersCollectionIterator.MoveNext()
        {
            return this._Interface.MoveNext();
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
        ~HttpHeadersCollectionIterator()
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