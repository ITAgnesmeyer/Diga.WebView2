using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Frame4Interface : WebView2Frame3Interface //, ICoreWebView2Frame4
    {
        private ComObjectHolder<ICoreWebView2Frame4> _Args;
        private ICoreWebView2Frame4 Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(WebView2Frame3Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame3Interface) + " Args is null");
                }

                return this._Args.Interface;
            }
            set
            {
                this._Args = new ComObjectHolder<ICoreWebView2Frame4>(value);
            }
        }

        public WebView2Frame4Interface(ICoreWebView2Frame4 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }

        public void PostSharedBufferToScript([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2SharedBuffer sharedBuffer, [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access, [In, MarshalAs(UnmanagedType.LPWStr)] string additionalDataAsJson)
        {
            this.Args.PostSharedBufferToScript(sharedBuffer, access, additionalDataAsJson);
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
    }
}