using System;
using System.Collections;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class HttpHeadersCollectionIterator :IEnumerator,IEnumerable, IWebView2HttpHeadersCollectionIterator
    {
        private IWebView2HttpHeadersCollectionIterator _Interface;

        
        public HttpHeadersCollectionIterator(IWebView2HttpHeadersCollectionIterator iface)
        {
            this._Interface = iface;
        }

        private IWebView2HttpHeadersCollectionIterator Tointerface()
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

        void IWebView2HttpHeadersCollectionIterator.GetCurrentHeader(out string name, out string value)
        {
            this._Interface.GetCurrentHeader(out name, out value);
        }

        void IWebView2HttpHeadersCollectionIterator.MoveNext(out int has_next)
        {
            this._Interface.MoveNext(out has_next);
        }

        bool IEnumerator.MoveNext()
        {
            this.Tointerface().MoveNext(out int hasNext);
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
    }
}