using System;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
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