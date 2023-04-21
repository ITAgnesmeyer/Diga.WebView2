using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ControllerOptionsInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2ControllerOptions> _Options;
        private bool _IsDesposed;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle) new SafeFileHandle(IntPtr.Zero, true);
    

        private ICoreWebView2ControllerOptions Options
        {
            get
            {
                if (this._Options == null)
                {
                    Debug.Print(nameof(WebView2ControllerOptionsInterface) + "WebView2ControllerOptionsInterface is null");

                    throw new InvalidOperationException("WebView2ControllerOptionsInterface is null!");
                }

                return this._Options.Interface;
            }
            set => this._Options = new ComObjectHolder<ICoreWebView2ControllerOptions>(value);
        }

        public WebView2ControllerOptionsInterface(ICoreWebView2ControllerOptions options)
        {
            this.Options = options ?? throw new ArgumentNullException(nameof(options));
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._IsDesposed)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                    this._Options = null;
                }

              
                this._IsDesposed = true;
            }
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string ProfileName { get => this.Options.ProfileName; set => this.Options.ProfileName = value; }
        public int IsInPrivateModeEnabled { get => this.Options.IsInPrivateModeEnabled; set => this.Options.IsInPrivateModeEnabled = value; }
    }

}