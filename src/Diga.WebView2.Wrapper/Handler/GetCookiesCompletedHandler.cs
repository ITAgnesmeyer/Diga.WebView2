using System.Threading.Tasks;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Handler
{
    public class GetCookiesCompletedHandler : ICoreWebView2GetCookiesCompletedHandler
    {
        private readonly TaskCompletionSource<(int, ICoreWebView2CookieList)> _Source;

        public GetCookiesCompletedHandler(TaskCompletionSource<(int, ICoreWebView2CookieList)> source)
        {
            _Source = source;
        }
        void ICoreWebView2GetCookiesCompletedHandler.Invoke(int result, ICoreWebView2CookieList cookieList)
        {
            _Source.SetResult((result, cookieList));
        }


    }
}