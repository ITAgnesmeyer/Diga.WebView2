using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2Environment8Interface : WebView2Environment7Interface, ICoreWebView2Environment8
    {
        private ICoreWebView2Environment8 _Environment;
        private ICoreWebView2Environment8 Environment
        {
            get
            {
                if (this._Environment == null)
                {
                    Debug.Print(nameof(WebView2Environment8Interface) + "." + nameof(this.Environment) + " is null");
                    throw new InvalidOperationException(nameof(WebView2Environment8Interface) + "." + nameof(this.Environment) + " is null");

                }
                return this._Environment;
            }
            set { this._Environment = value; }
        }

        public WebView2Environment8Interface(ICoreWebView2Environment8 environment):base(environment)
        {
            if (environment == null)
                throw new ArgumentNullException(nameof(environment));

            this.Environment = environment;            
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