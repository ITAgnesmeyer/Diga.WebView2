using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Environment5Interface : WebView2Environment4Interface, ICoreWebView2Environment5
    {
        private ICoreWebView2Environment5 _Environment;
        private ICoreWebView2Environment5 Environment
        {
            get
            {
                if (_Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment5Interface) + "." + nameof(Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment5Interface) + "." + nameof(Environment) + " is null");

                }
                return _Environment;
            }
            set { _Environment = value; }
        }

        public WebView2Environment5Interface(ICoreWebView2Environment5 environment) : base(environment)
        {
              if(environment == null)
                throw new ArgumentNullException(nameof(environment));

            this._Environment = environment;
        }

        public void add_BrowserProcessExited([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Environment.add_BrowserProcessExited(eventHandler, out token);
        }

        public void remove_BrowserProcessExited([In] EventRegistrationToken token)
        {
            Environment.remove_BrowserProcessExited(token);
        }
        private bool _IsDisposed;
        protected override void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this._Environment = null;
                this._IsDisposed = true;
            }
            base.Dispose(disposing);
        }
    }
}