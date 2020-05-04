using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class HttpRequestHeaders : IWebView2HttpRequestHeaders
    {
        private IWebView2HttpRequestHeaders _Interface;

        public HttpRequestHeaders(IWebView2HttpRequestHeaders iface)
        {
            this._Interface = iface;
        }

        private IWebView2HttpRequestHeaders ToInterface()
        {
            return this;
        }
        public string GetHeader(string name)
        {
            this.ToInterface().GetHeader(name, out string value);
            return value;
        }

        public bool Contains(string name)
        {
            int contains = this.ToInterface().Contains(name);
            return new CBOOL(contains);
        }

        public void SetHeader(string name, string value)
        {
            this.ToInterface().SetHeader(name, value);
        }

        public void RemoveHeader(string name)
        {
            this.ToInterface().RemoveHeader(name);
        }

        public HttpHeadersCollectionIterator GetIterator()
        {
            this.ToInterface().GetIterator(out IWebView2HttpHeadersCollectionIterator iterator);
            return new HttpHeadersCollectionIterator(iterator);
        }
        void IWebView2HttpRequestHeaders.GetHeader(string name, out string value)
        {
            this._Interface.GetHeader(name, out value);
        }

        int IWebView2HttpRequestHeaders.Contains(string name)
        {
            return this._Interface.Contains(name);
        }

        void IWebView2HttpRequestHeaders.SetHeader(string name, string value)
        {
            this._Interface.SetHeader(name, value);
        }

        void IWebView2HttpRequestHeaders.RemoveHeader(string name)
        {
            this._Interface.RemoveHeader(name);
        }

        void IWebView2HttpRequestHeaders.GetIterator(out IWebView2HttpHeadersCollectionIterator iterator)
        {
            this._Interface.GetIterator(out iterator);
        }
    }
}