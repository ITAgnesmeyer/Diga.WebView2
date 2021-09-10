using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class CookieManager : ICoreWebView2CookieManager
    {
        private ICoreWebView2CookieManager _Interface;
        
        public CookieManager(ICoreWebView2CookieManager iface)
        {
            this._Interface = iface;
        }

        public ICoreWebView2CookieManager ToInterface()
        {
            return this;
        }

        public Cookie CreateCookie(string name, string value, string Domain, string Path) =>
            new Cookie(this.ToInterface().CreateCookie(name, value, Domain, Path));
        ICoreWebView2Cookie ICoreWebView2CookieManager.CreateCookie(string name, string value, string Domain, string Path)
        {
            return this._Interface.CreateCookie(name, value, Domain, Path);
        }

        public Cookie CopyCookie(Cookie cookieParent) => new Cookie(this.ToInterface().CopyCookie(cookieParent));
        ICoreWebView2Cookie ICoreWebView2CookieManager.CopyCookie(ICoreWebView2Cookie cookieParam)
        {
            return this._Interface.CopyCookie(cookieParam);
        }

        void ICoreWebView2CookieManager.GetCookies(string uri, ICoreWebView2GetCookiesCompletedHandler handler)
        {
            this._Interface.GetCookies(uri, handler);
        }

        
        public async Task<CookieList> GetCookies(string uri)
        {
            TaskCompletionSource<(int, ICoreWebView2CookieList)> source =
                new TaskCompletionSource<(int, ICoreWebView2CookieList)>();
            GetCookiesCompletedHandler handler = new GetCookiesCompletedHandler(source);
            this.ToInterface().GetCookies(uri, handler);
            (int errorCode, ICoreWebView2CookieList resultObject) result = await source.Task;
            HRESULT resultCode = result.errorCode;
            if (resultCode != HRESULT.S_OK)
                throw Marshal.GetExceptionForHR(resultCode);
            return new CookieList( result.resultObject);

        }

       
        public void AddOrUpdateCookie(Cookie cookie) => this.ToInterface().AddOrUpdateCookie(cookie);
        void ICoreWebView2CookieManager.AddOrUpdateCookie(ICoreWebView2Cookie cookie)
        {
            this._Interface.AddOrUpdateCookie(cookie);
        }

        public void DeleteCookie(Cookie cookie) => this.ToInterface().DeleteCookie(cookie);
        void ICoreWebView2CookieManager.DeleteCookie(ICoreWebView2Cookie cookie)
        {
            this._Interface.DeleteCookie(cookie);
        }

        public void DeleteCookies(string name, string uri) => this.ToInterface().DeleteCookies(name, uri);
        void ICoreWebView2CookieManager.DeleteCookies(string name, string uri)
        {
            this._Interface.DeleteCookies(name, uri);
        }

        public void DeleteCookiesWithDomainAndPath(string name, string domain, string path) =>
            this.ToInterface().DeleteCookiesWithDomainAndPath(name, domain, path);
        void ICoreWebView2CookieManager.DeleteCookiesWithDomainAndPath(string name, string Domain, string Path)
        {
            this._Interface.DeleteCookiesWithDomainAndPath(name, Domain, Path);
        }

        public void DeleteAllCookies() => this.ToInterface().DeleteAllCookies();
        void ICoreWebView2CookieManager.DeleteAllCookies()
        {
            this._Interface.DeleteAllCookies();
        }
    }
}