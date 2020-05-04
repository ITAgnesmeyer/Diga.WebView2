using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class HttpResponseHeaders : IWebView2HttpResponseHeaders
    {
        private IWebView2HttpResponseHeaders _Interface;


        public HttpResponseHeaders(IWebView2HttpResponseHeaders iface)
        {
            this._Interface = iface;
        }

        private IWebView2HttpResponseHeaders ToInterface()
        {
            return this;
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
            this.ToInterface().GetHeaders(name, out var iterator);
            return new HttpHeadersCollectionIterator(iterator);
        }
        public HttpHeadersCollectionIterator GetIterator()
        {
            this.ToInterface().GetIterator(out IWebView2HttpHeadersCollectionIterator iterator);
            return new HttpHeadersCollectionIterator(iterator);
        }

        void IWebView2HttpResponseHeaders.AppendHeader(string name, string value)
        {
            this._Interface.AppendHeader(name, value);
        }

        int IWebView2HttpResponseHeaders.Contains(string name)
        {
            return this._Interface.Contains(name);
        }

        void IWebView2HttpResponseHeaders.GetHeaders(string name, out IWebView2HttpHeadersCollectionIterator iterator)
        {
            this._Interface.GetHeaders(name, out iterator);
        }

        void IWebView2HttpResponseHeaders.GetIterator(out IWebView2HttpHeadersCollectionIterator iterator)
        {
            this._Interface.GetIterator(out iterator);
        }
    }
}