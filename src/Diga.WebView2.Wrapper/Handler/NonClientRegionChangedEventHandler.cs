using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Handler
{
    public class NonClientRegionChangedEventHandler : ICoreWebView2NonClientRegionChangedEventHandler
    {
        public event EventHandler<NonClientRegionChangedEventArgs> NonClientRegionChanged;


        protected virtual void OnNonClientRegionChanged(NonClientRegionChangedEventArgs e)
        {
            NonClientRegionChanged?.Invoke(this, e);
        }

        public void Invoke([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CompositionController sender, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2NonClientRegionChangedEventArgs args)
        {
            try
            {
                OnNonClientRegionChanged(new NonClientRegionChangedEventArgs(new WebView2CompositionController((ICoreWebView2CompositionController4)sender), args));
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(NonClientRegionChangedEventHandler) + " Exception:" + ex.ToString());
            }

        }
    }

}