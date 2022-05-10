using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Frame2Interface : WebView2FrameInterface, ICoreWebView2Frame2
    {
        private ICoreWebView2Frame2 _Args;
        private ICoreWebView2Frame2 Args
        {
            get
            {
                if (_Args == null)
                {
                    Debug.Print(nameof(WebView2Frame2Interface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2Frame2Interface) + " Args is null");
                }

                return _Args;
            }
            set
            {
                _Args = value;
            }
        }

        public WebView2Frame2Interface(ICoreWebView2Frame2 args) : base(args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));
            _Args = args;
        }
        public void add_NavigationStarting([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationStartingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NavigationStarting(eventHandler, out token);
        }

        public void remove_NavigationStarting([In] EventRegistrationToken token)
        {
            Args.remove_NavigationStarting(token);
        }

        public void add_ContentLoading([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameContentLoadingEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_ContentLoading(eventHandler, out token);
        }

        public void remove_ContentLoading([In] EventRegistrationToken token)
        {
            Args.remove_ContentLoading(token);
        }

        public void add_NavigationCompleted([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_NavigationCompleted(eventHandler, out token);
        }

        public void remove_NavigationCompleted([In] EventRegistrationToken token)
        {
            Args.remove_NavigationCompleted(token);
        }

        public void add_DOMContentLoaded([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler, out EventRegistrationToken token)
        {
            Args.add_DOMContentLoaded(eventHandler, out token);
        }

        public void remove_DOMContentLoaded([In] EventRegistrationToken token)
        {
            Args.remove_DOMContentLoaded(token);
        }

        public void ExecuteScript([In, MarshalAs(UnmanagedType.LPWStr)] string javaScript, [In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ExecuteScriptCompletedHandler handler)
        {
            Args.ExecuteScript(javaScript, handler);
        }

        public void PostWebMessageAsJson([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsJson)
        {
            Args.PostWebMessageAsJson(webMessageAsJson);
        }

        public void PostWebMessageAsString([In, MarshalAs(UnmanagedType.LPWStr)] string webMessageAsString)
        {
            Args.PostWebMessageAsString(webMessageAsString);
        }

        public void add_WebMessageReceived([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2FrameWebMessageReceivedEventHandler handler, out EventRegistrationToken token)
        {
            Args.add_WebMessageReceived(handler, out token);
        }

        public void remove_WebMessageReceived([In] EventRegistrationToken token)
        {
            Args.remove_WebMessageReceived(token);
        }
    }
}