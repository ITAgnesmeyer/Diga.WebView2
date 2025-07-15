using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Frame6Interface : WebView2Frame5Interface //, ICoreWebView2Frame6
    {
        private ComObjectHolder<ICoreWebView2Frame6> _Args;
        private ICoreWebView2Frame6 Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(WebView2Frame6Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame6Interface) + " Args is null");
                }
                return this._Args.Interface;
            }
            set => this._Args = new ComObjectHolder<ICoreWebView2Frame6>(value);
        }
        public WebView2Frame6Interface(ICoreWebView2Frame6 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }
        private bool disposedValue;
        protected override void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this._Args = null;
                }
                this.disposedValue = true;
            }
            base.Dispose(disposing);
        }

        public void add_ScreenCaptureStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameScreenCaptureStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_ScreenCaptureStarting(eventHandler, out token);
        }

        public void remove_ScreenCaptureStarting([In] EventRegistrationToken token)
        {
            Args.remove_ScreenCaptureStarting(token);
        }
    }
}