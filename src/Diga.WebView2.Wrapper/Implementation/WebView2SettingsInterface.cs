using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;
using Microsoft.Win32.SafeHandles;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2SettingsInterface :  IDisposable
    {
        private ComObjectHolder<ICoreWebView2Settings> _Settings;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private readonly SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2Settings Settings
        {
            get
            {
                if (this._Settings == null)
                {
                    Debug.Print(nameof(WebView2SettingsInterface) + "." + nameof(this.Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2SettingsInterface) + "." + nameof(this.Settings) + " is null");

                }
                return this._Settings.Interface;
            }
            set => this._Settings = new ComObjectHolder<ICoreWebView2Settings>(value);
        }



        public WebView2SettingsInterface(ICoreWebView2Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
            this.Settings = settings;
        }

        public int IsScriptEnabled { get => this.Settings.IsScriptEnabled; set => this.Settings.IsScriptEnabled = value; }
        public int IsWebMessageEnabled { get => this.Settings.IsWebMessageEnabled; set => this.Settings.IsWebMessageEnabled = value; }
        public int AreDefaultScriptDialogsEnabled { get => this.Settings.AreDefaultScriptDialogsEnabled; set => this.Settings.AreDefaultScriptDialogsEnabled = value; }
        public int IsStatusBarEnabled { get => this.Settings.IsStatusBarEnabled; set => this.Settings.IsStatusBarEnabled = value; }
        public int AreDevToolsEnabled { get => this.Settings.AreDevToolsEnabled; set => this.Settings.AreDevToolsEnabled = value; }
        public int AreDefaultContextMenusEnabled { get => this.Settings.AreDefaultContextMenusEnabled; set => this.Settings.AreDefaultContextMenusEnabled = value; }
        public int AreHostObjectsAllowed { get => this.Settings.AreHostObjectsAllowed; set => this.Settings.AreHostObjectsAllowed = value; }
        public int IsZoomControlEnabled { get => this.Settings.IsZoomControlEnabled; set => this.Settings.IsZoomControlEnabled = value; }
        public int IsBuiltInErrorPageEnabled { get => this.Settings.IsBuiltInErrorPageEnabled; set => this.Settings.IsBuiltInErrorPageEnabled = value; }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (this._IsDisposed) return;
            if (disposing)
            {
                this.handle.Dispose();
                this._Settings = null;
                this._IsDisposed = true;
            }
        }


        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}