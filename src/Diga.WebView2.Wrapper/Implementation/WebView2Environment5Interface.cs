using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment5Interface : WebView2Environment4Interface, ICoreWebView2Environment5
    {
        private ComObjectHolder< ICoreWebView2Environment5> _Environment;
        private ICoreWebView2Environment5 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment5Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment5Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set => this._Environment = new ComObjectHolder<ICoreWebView2Environment5>( value);
        }

        public WebView2Environment5Interface(ICoreWebView2Environment5 environment) : base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }

        public void add_BrowserProcessExited([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2BrowserProcessExitedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Environment.add_BrowserProcessExited(eventHandler, out token);
        }

        public void remove_BrowserProcessExited([In] EventRegistrationToken token)
        {
            this.Environment.remove_BrowserProcessExited(token);
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