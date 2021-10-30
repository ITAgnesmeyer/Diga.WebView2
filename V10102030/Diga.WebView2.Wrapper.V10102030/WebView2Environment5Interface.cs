using Diga.WebView2.Interop;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment5Interface:WebView2Environment4Interface,ICoreWebView2Environment5
    {
        private  ICoreWebView2Environment5 _Environment5;
        public WebView2Environment5Interface(ICoreWebView2Environment5 environment):base(environment)
        {
            this._Environment5 = environment;
        }

        public void add_BrowserProcessExited([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token)
        {
            _Environment5.add_BrowserProcessExited(eventHandler, out token);
        }

        public void remove_BrowserProcessExited([In] EventRegistrationToken token)
        {
            _Environment5.remove_BrowserProcessExited(token);
        }

         protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                this._Environment5 = null;
            }
            base.Dispose(disposing);
        }
    }
}