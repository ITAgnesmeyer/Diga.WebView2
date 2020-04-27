using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class HttpResponseHeaders : ICoreWebView2HttpResponseHeaders
    {
        private ICoreWebView2HttpResponseHeaders _Interface;


        public HttpResponseHeaders(ICoreWebView2HttpResponseHeaders iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2HttpResponseHeaders ToInterface()
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
    }
}