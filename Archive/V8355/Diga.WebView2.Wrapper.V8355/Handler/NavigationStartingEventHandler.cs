using System;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NavigationStartingEventHandler : IWebView2NavigationStartingEventHandler
    {
        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;

        public void Invoke(IWebView2WebView sender, IWebView2NavigationStartingEventArgs args)
        {
            OnNavigationStarting(new NavigationStartingEventArgs(args));
        }

        protected virtual void OnNavigationStarting(NavigationStartingEventArgs e)
        {
            NavigationStarting?.Invoke(this, e);
        }
    }
}