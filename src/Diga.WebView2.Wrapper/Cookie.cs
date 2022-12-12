using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class Cookie //: ICoreWebView2Cookie
    {
      
        private ComObjectHolder<ICoreWebView2Cookie> _Interface;

        private ICoreWebView2Cookie Interface
        {
            get
            {
                return this._Interface.Interface;
            }
            set => this._Interface = new ComObjectHolder<ICoreWebView2Cookie>(value);
        }
        //public Cookie()
        //{
        //    this._Interface = this.ToInterface();
        //}
        public Cookie(ICoreWebView2Cookie iface)
        {
            this.Interface = iface;
        }

        public ICoreWebView2Cookie ToInterface()
        {
            return this.Interface;
        }

        public string name => this.Interface.name;
       

        public string value
        {
            get => this.Interface.value;
            set => this.Interface.value = value;
        }
      

        public string Domain => this.Interface.Domain;

        

        public string Path => this.Interface.Path;
        

        public double Expires
        {
            get => this.Interface.Expires;
            set => this.Interface.Expires = value;
        }

        public CBOOL IsHttpOnly
        {
            get => this.Interface.IsHttpOnly;
            set => this.Interface.IsHttpOnly = value;
        }


        public COREWEBVIEW2_COOKIE_SAME_SITE_KIND SameSite
        {
            get => this.Interface.SameSite;
            set => this.Interface.SameSite = value;
        }

        public CBOOL IsSecure
        {
            get => this.Interface.IsSecure;
            set => this.Interface.IsSecure = value;
        }


        public bool IsSession => new CBOOL(this.Interface.IsSession);
        
    }
}