using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{

   
    public class HttpRequestHeaders : ICoreWebView2HttpRequestHeaders
    {
        private ICoreWebView2HttpRequestHeaders _Interface;

        public HttpRequestHeaders(ICoreWebView2HttpRequestHeaders iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2HttpRequestHeaders ToInterface()
        {
            return _Interface;
        }
        public string GetHeader(string name)
        {
            
            return this.ToInterface().GetHeader(name);
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
            var iterator = this.ToInterface().GetIterator();
            return new HttpHeadersCollectionIterator(iterator);
        }
       
        string ICoreWebView2HttpRequestHeaders.GetHeader(string name)
        {
            return this._Interface.GetHeader(name);
        }

        ICoreWebView2HttpHeadersCollectionIterator ICoreWebView2HttpRequestHeaders.GetHeaders(string name)
        {
            return this._Interface.GetHeaders(name);
        }

        int ICoreWebView2HttpRequestHeaders.Contains(string name)
        {
            return this._Interface.Contains(name);
        }

        void ICoreWebView2HttpRequestHeaders.SetHeader(string name, string value)
        {
            this._Interface.SetHeader(name, value);
        }

        void ICoreWebView2HttpRequestHeaders.RemoveHeader(string name)
        {
            this._Interface.RemoveHeader(name);
        }

        ICoreWebView2HttpHeadersCollectionIterator ICoreWebView2HttpRequestHeaders.GetIterator()
        {
            return this._Interface.GetIterator();
        }
    }
}