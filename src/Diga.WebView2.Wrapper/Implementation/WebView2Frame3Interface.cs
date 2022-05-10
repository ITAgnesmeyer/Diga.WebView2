using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Frame3Interface : WebView2Frame2Interface, ICoreWebView2Frame3
    {
        private ICoreWebView2Frame3 _Args;
        private ICoreWebView2Frame3 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2Frame3Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame3Interface) + " Args is null");
                }

                return _Args;
            }
            set
            {
                _Args = value;
            }
        }

        public WebView2Frame3Interface(ICoreWebView2Frame3 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            Args = args;
        }

        public void add_PermissionRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FramePermissionRequestedEventHandler handler, out EventRegistrationToken token)
        {
            Args.add_PermissionRequested(handler, out token);
        }

        public void remove_PermissionRequested([In] EventRegistrationToken token)
        {
            Args.remove_PermissionRequested(token);
        }
    }
}