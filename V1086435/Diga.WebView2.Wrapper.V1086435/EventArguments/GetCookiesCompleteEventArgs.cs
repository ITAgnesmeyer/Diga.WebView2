using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class GetCookiesCompleteEventArgs : EventArgs
    {
        public CookieList CookieList{get;}
        public int Result{get;}

        public GetCookiesCompleteEventArgs(int result , CookieList cookieList)
        {
            this.Result = result;
            this.CookieList = cookieList;
        }
    }
}