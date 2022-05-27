using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment9Interface : WebView2Environment8Interface, ICoreWebView2Environment9
    {
        private ICoreWebView2Environment9 _Environment;
        private ICoreWebView2Environment9 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment9Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment9Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment;
            }
            set { this._Environment = value; }
        }

        public WebView2Environment9Interface(ICoreWebView2Environment9 environment):base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            this.Environment = environment;  
        }

        [return: MarshalAs(UnmanagedType.IUnknown)]
        public object GetAutomationProviderForWindow(IntPtr hwnd)
        {
            return this.Environment.GetAutomationProviderForWindow(hwnd);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ContextMenuItem CreateContextMenuItem([In, MarshalAs(UnmanagedType.LPWStr)] string Label, [MarshalAs(UnmanagedType.Interface), In] IStream iconStream, [In] COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind)
        {
            return this.Environment.CreateContextMenuItem(Label, iconStream, Kind);
        }
    }
}