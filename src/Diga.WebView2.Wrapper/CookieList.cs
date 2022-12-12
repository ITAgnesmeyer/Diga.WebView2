using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class CookieList //: ICoreWebView2CookieList
    {
       
        private ComObjectHolder< ICoreWebView2CookieList> _Interface;

        public ICoreWebView2CookieList Interface
        {
            get
            {
                return this._Interface.Interface;
            }
            set => this._Interface = new ComObjectHolder<ICoreWebView2CookieList>(value);
        }
        public CookieList(ICoreWebView2CookieList iface)
        {
            this.Interface = iface;
        }

        private ICoreWebView2CookieList ToInterface()
        {
            return this.Interface;
        }

        public uint Count => this.Interface.Count;

        public Cookie GetValueAtIndex(uint index)
        {
            var ifae = this.Interface.GetValueAtIndex(index);
            return new Cookie(ifae);
        }
        

    }
}