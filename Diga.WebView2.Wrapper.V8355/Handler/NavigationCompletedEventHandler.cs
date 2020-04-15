using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class NavigationCompletedEventHandler : IWebView2NavigationCompletedEventHandler
    {
        public event EventHandler<NavigationCompletedEventArgs> NavigaionCompleted;
        public void Invoke(IWebView2WebView sender, IWebView2NavigationCompletedEventArgs args)
        {
            NavigationCompletedEventArgs eventArgs = new NavigationCompletedEventArgs((ErrorStatus)args.WebErrorStatus, args.IsSuccess==0,0);
            OnNavigaionCompleted(eventArgs);

        }

        protected virtual void OnNavigaionCompleted(NavigationCompletedEventArgs e)
        {
            NavigaionCompleted?.Invoke(this, e);
        }
    }
}