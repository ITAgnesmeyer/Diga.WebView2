using System;
using System.Diagnostics;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.EventArguments;

namespace Diga.WebView2.Wrapper.Handler
{
    public class BrowserProcessExitedEventHandler : ICoreWebView2BrowserProcessExitedEventHandler
    {
        public event EventHandler<BrowserProcessExitedEventArgs> BrowserProcessExited;
        public void Invoke(ICoreWebView2Environment sender, ICoreWebView2BrowserProcessExitedEventArgs args)
        {
            try
            {
                OnBrowserProcessExited(new BrowserProcessExitedEventArgs(args));
            }
            catch (Exception ex)
            {

                Debug.Print(nameof(BrowserProcessExitedEventHandler) + " Exception:" + ex.ToString());
            }
            
        }

        protected virtual void OnBrowserProcessExited(BrowserProcessExitedEventArgs e)
        {
            BrowserProcessExited?.Invoke(this, e);
        }
    }
}