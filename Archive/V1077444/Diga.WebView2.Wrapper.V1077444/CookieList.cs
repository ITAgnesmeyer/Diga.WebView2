using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class CookieList : ICoreWebView2CookieList
    {
       
        private ICoreWebView2CookieList _Interface;

        public CookieList(ICoreWebView2CookieList iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2CookieList ToInterface()
        {
            return this;
        }

        public uint Count => this.ToInterface().Count;

        public Cookie GetValueAtIndex(uint index)
        {
            var ifae = this.ToInterface().GetValueAtIndex(index);
            return new Cookie(ifae);
        }
        uint ICoreWebView2CookieList.Count => this._Interface.Count;

        ICoreWebView2Cookie ICoreWebView2CookieList.GetValueAtIndex(uint index)
        {
            return this._Interface.GetValueAtIndex(index);
        }
    }
}