using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NavigationCompletedEventHandler : IWebView2NavigationCompletedEventHandler
    {
        public event EventHandler<NavigationCompletedEventArgs> NavigaionCompleted;
        public void Invoke(IWebView2WebView sender, IWebView2NavigationCompletedEventArgs args)
        {
            NavigationCompletedEventArgs eventArgs = new NavigationCompletedEventArgs((ErrorStatus)args.WebErrorStatus, new CBOOL(args.IsSuccess),0);
            OnNavigaionCompleted(eventArgs);

        }

        protected virtual void OnNavigaionCompleted(NavigationCompletedEventArgs e)
        {
            NavigaionCompleted?.Invoke(this, e);
        }
    }
}