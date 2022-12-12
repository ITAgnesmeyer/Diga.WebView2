using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment8Interface : WebView2Environment7Interface //, ICoreWebView2Environment8
    {
        private ComObjectHolder< ICoreWebView2Environment8> _Environment;
        private ICoreWebView2Environment8 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment8Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment8Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment.Interface;
            }
            set { this._Environment = new ComObjectHolder<ICoreWebView2Environment8>(value); }
        }

        public WebView2Environment8Interface(ICoreWebView2Environment8 environment):base(environment)
        {
            this.Environment = environment ?? throw new ArgumentNullException(nameof(environment));            
        }

        public void add_ProcessInfosChanged([In, MarshalAs(UnmanagedType.Interface)] ICoreWebView2ProcessInfosChangedEventHandler eventHandler, out EventRegistrationToken token)
        {
            this.Environment.add_ProcessInfosChanged(eventHandler, out token);
        }

        public void remove_ProcessInfosChanged([In] EventRegistrationToken token)
        {
            this.Environment.remove_ProcessInfosChanged(token);
        }

        [return: MarshalAs(UnmanagedType.Interface)]
        public ICoreWebView2ProcessInfoCollection GetProcessInfos()
        {
            return this.Environment.GetProcessInfos();
        }
    }
}