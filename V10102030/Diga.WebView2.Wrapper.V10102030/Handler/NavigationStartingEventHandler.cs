using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NavigationStartingEventHandler : ICoreWebView2NavigationStartingEventHandler
    {
        public event EventHandler<NavigationStartingEventArgs> NavigationStarting;

        public void Invoke(ICoreWebView2 sender, ICoreWebView2NavigationStartingEventArgs args)
        {
            try
            {
                OnNavigationStarting(new NavigationStartingEventArgs(args));
            }
            catch (Exception ex)
            {
                Debug.Print(nameof(NavigationStartingEventHandler) + " Exception:" + ex.ToString());

            }

        }

        protected virtual void OnNavigationStarting(NavigationStartingEventArgs e)
        {
            NavigationStarting?.Invoke(this, e);
        }
    }
}