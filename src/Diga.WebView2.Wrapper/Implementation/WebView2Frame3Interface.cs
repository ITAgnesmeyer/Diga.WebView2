using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
  
    public class WebView2Frame3Interface : WebView2Frame2Interface
    {
        private ComObjectHolder<ICoreWebView2Frame3> _Args;
        private ICoreWebView2Frame3 Args
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
                this._Args = new ComObjectHolder<ICoreWebView2Frame3>(value);
            }
        }

        public WebView2Frame3Interface(ICoreWebView2Frame3 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            this.Args = args;
        }
        public ICoreWebView2Frame3 GetInterface() => this.Args;

        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FramePermissionRequestedEventHandler handler, out EventRegistrationToken token)
        {
            this.Args.add_PermissionRequested(handler, out token);
        }

        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            this.Args.remove_PermissionRequested(token);
        }
    }
}