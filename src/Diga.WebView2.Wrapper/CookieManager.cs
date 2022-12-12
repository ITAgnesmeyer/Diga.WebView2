using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Handler;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class CookieManager //: ICoreWebView2CookieManager
    {
        private ComObjectHolder<ICoreWebView2CookieManager> _Interface;

        private ICoreWebView2CookieManager Interface
        {
            get
            {
                return this._Interface.Interface;
            }
            set => this._Interface = new ComObjectHolder<ICoreWebView2CookieManager>(value);
        }

        public CookieManager(ICoreWebView2CookieManager iface)
        {
            this.Interface = iface;
        }

        public ICoreWebView2CookieManager ToInterface()
        {
            return this.Interface;
        }

        public Cookie CreateCookie(string name, string value, string Domain, string Path) =>
            new Cookie(this.Interface.CreateCookie(name, value, Domain, Path));
       

        public Cookie CopyCookie(Cookie cookieParent) => new Cookie(this.Interface.CopyCookie(cookieParent.ToInterface()));


        
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

       
        public void AddOrUpdateCookie(Cookie cookie) => this.Interface.AddOrUpdateCookie(cookie.ToInterface());

        public void DeleteCookie(Cookie cookie) => this.Interface.DeleteCookie(cookie.ToInterface());

        public void DeleteCookies(string name, string uri) => this.Interface.DeleteCookies(name, uri);
        public void DeleteCookiesWithDomainAndPath(string name, string domain, string path) =>
            this.Interface.DeleteCookiesWithDomainAndPath(name, domain, path);

        public void DeleteAllCookies() => this.Interface.DeleteAllCookies();
    }
}