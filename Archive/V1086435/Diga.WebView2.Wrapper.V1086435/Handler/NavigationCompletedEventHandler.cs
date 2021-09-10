using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Handler
{
    public class NavigationCompletedEventHandler : ICoreWebView2NavigationCompletedEventHandler
    {
        public event EventHandler<NavigationCompletedEventArgs> NavigaionCompleted;
        public void Invoke(ICoreWebView2 sender, ICoreWebView2NavigationCompletedEventArgs args)
        {
            NavigationCompletedEventArgs eventArgs = new NavigationCompletedEventArgs((ErrorStatus)args.WebErrorStatus, args.IsSuccess==0,args.NavigationId);
            OnNavigaionCompleted(eventArgs);

        }

        protected virtual void OnNavigaionCompleted(NavigationCompletedEventArgs e)
        {
            NavigaionCompleted?.Invoke(this, e);
        }
    }
}