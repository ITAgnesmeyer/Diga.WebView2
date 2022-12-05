﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2View11Interface : WebView2View10Interface, ICoreWebView2_11
    {
        private ICoreWebView2_11 _WebView;
        private ICoreWebView2_11 WebView
        {
            get
            {
                if (this._WebView == null)
                {
                    Debug.Print(nameof(WebView2View11Interface) + "." + nameof(this.WebView) + " is null");
                    throw new InvalidOperationException(nameof(WebView2View11Interface) + "." + nameof(this.WebView) + " is null");

                }
                return this._WebView;
            }
            set
            {
                this._WebView = value;
            }


        }

        public WebView2View11Interface(ICoreWebView2_11 webView) : base(webView)
        {
            this._WebView = webView ?? throw new ArgumentNullException(nameof(webView));
        }

        public void CallDevToolsProtocolMethodForSession([In, MarshalAs(UnmanagedType.LPWStr)] string sessionId, [In, MarshalAs(UnmanagedType.LPWStr)] string methodName, [In, MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler)
        {
            this.WebView.CallDevToolsProtocolMethodForSession(sessionId, methodName, parametersAsJson, handler);
        }

        public void add_ContextMenuRequested([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuRequestedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.WebView.add_ContextMenuRequested(eventHandler, out token);
        }

        public void remove_ContextMenuRequested([In] EventRegistrationToken token)
        {
            this.WebView.remove_ContextMenuRequested(token);
        }
    }
}