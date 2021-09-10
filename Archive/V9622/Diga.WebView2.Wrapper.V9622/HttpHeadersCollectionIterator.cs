using System;
using System.Collections;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class HttpHeadersCollectionIterator :IEnumerator,IEnumerable, ICoreWebView2HttpHeadersCollectionIterator
    {
        private ICoreWebView2HttpHeadersCollectionIterator _Interface;

        
        public HttpHeadersCollectionIterator(ICoreWebView2HttpHeadersCollectionIterator iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2HttpHeadersCollectionIterator Tointerface()
        {
            return this;
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
    }
}