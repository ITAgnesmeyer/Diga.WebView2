using System;
using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class GetCookiesCompletedHandler : ICoreWebView2GetCookiesCompletedHandler
    {
        private readonly TaskCompletionSource<(int, ICoreWebView2CookieList)> _Source;

        public GetCookiesCompletedHandler(TaskCompletionSource<(int, ICoreWebView2CookieList)> source)
        {
            this._Source = source;
        }
        void ICoreWebView2GetCookiesCompletedHandler.Invoke(int result, ICoreWebView2CookieList cookieList)
        {
            this._Source.SetResult((result, cookieList));
        }

        
    }
}