using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2ProfileInterface :  IDisposable
    {
        private ComObjectHolder< ICoreWebView2Profile> _Args;
        private bool disposedValue;

        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        private ICoreWebView2Profile Args
        {
            get
            {
                if (this._Args == null)
                {
                    Debug.Print(nameof(WebView2ProfileInterface) + " Args is null");
                    throw new InvalidOperationException(nameof(WebView2ProfileInterface) + " Args is null");
                }

                return this._Args.Interface;
            }
            set => this._Args = new ComObjectHolder<ICoreWebView2Profile>(value);
        }

        public WebView2ProfileInterface(ICoreWebView2Profile profile)
        {
            this.Args = profile ?? throw new ArgumentNullException(nameof(profile));
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    this.handle.Dispose();
                }
                this.disposedValue = true;
            }
        }



        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public string ProfileName => this.Args.ProfileName;

        public int IsInPrivateModeEnabled => this.Args.IsInPrivateModeEnabled;

        public string ProfilePath => this.Args.ProfilePath;

        public string DefaultDownloadFolderPath { get => this.Args.DefaultDownloadFolderPath; set => this.Args.DefaultDownloadFolderPath = value; }
        public COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme { get => this.Args.PreferredColorScheme; set => this.Args.PreferredColorScheme = value; }
    }
}