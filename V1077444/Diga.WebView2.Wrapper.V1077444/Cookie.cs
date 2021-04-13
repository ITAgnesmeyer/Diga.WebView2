using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class Cookie : ICoreWebView2Cookie
    {
      
        private ICoreWebView2Cookie _Interface;

        public Cookie()
        {
            this._Interface = this.ToInterface();
        }
        public Cookie(ICoreWebView2Cookie iface)
        {
            this._Interface = iface;
        }

        private ICoreWebView2Cookie ToInterface()
        {
            return this;
        }

        public string name => this.ToInterface().name;
        string ICoreWebView2Cookie.name => this._Interface.name;

        public string value
        {
            get => this.ToInterface().value;
            set => this.ToInterface().value = value;
        }
        string ICoreWebView2Cookie.value
        {
            get => this._Interface.value;
            set => this._Interface.value = value;
        }

        public string Domain => this.ToInterface().Domain;

        string ICoreWebView2Cookie.Domain => this._Interface.Domain;

        public string Path => this.ToInterface().Path;
        string ICoreWebView2Cookie.Path => this._Interface.Path;

        public double Expires
        {
            get => this.ToInterface().Expires;
            set => this.ToInterface().Expires = value;
        }
        double ICoreWebView2Cookie.Expires
        {
            get => this._Interface.Expires;
            set => this._Interface.Expires = value;
        }

        public CBOOL IsHttpOnly
        {
            get => this.ToInterface().IsHttpOnly;
            set => this.ToInterface().IsHttpOnly = value;
        }

        int ICoreWebView2Cookie.IsHttpOnly
        {
            get => this._Interface.IsHttpOnly;
            set => this._Interface.IsHttpOnly = value;
        }

        public COREWEBVIEW2_COOKIE_SAME_SITE_KIND SameSite
        {
            get => this.ToInterface().SameSite;
            set => this.ToInterface().SameSite = value;
        }
        COREWEBVIEW2_COOKIE_SAME_SITE_KIND ICoreWebView2Cookie.SameSite
        {
            get => this._Interface.SameSite;
            set => this._Interface.SameSite = value;
        }

        public CBOOL IsSecure
        {
            get => this.ToInterface().IsSecure;
            set => this.ToInterface().IsSecure = value;
        }

        int ICoreWebView2Cookie.IsSecure
        {
            get => this._Interface.IsSecure;
            set => this._Interface.IsSecure = value;
        }

        public CBOOL IsSession => this.ToInterface().IsSession;
        int ICoreWebView2Cookie.IsSession => this._Interface.IsSession;
    }
}