using Diga.WebView2.Interop;
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Implementation
{
    public class WebView2SettingsInterface : ICoreWebView2Settings, IDisposable
    {
        private object _Settings;
        /// Wraps in SafeHandle so resources can be released if consumer forgets to call Dispose. Recommended
        ///             pattern for any type that is not sealed.
        ///             https://docs.microsoft.com/dotnet/api/system.idisposable#idisposable-and-the-inheritance-hierarchy
        private SafeHandle handle = (SafeHandle)new SafeFileHandle(IntPtr.Zero, true);
        private ICoreWebView2Settings Settings
        {
            get
            {
                if (_Settings == null)
                {
                    Debug.Print(nameof(WebView2SettingsInterface) + "." + nameof(Settings) + " is null");
                    throw new InvalidOperationException(nameof(WebView2SettingsInterface) + "." + nameof(Settings) + " is null");

                }
                return (ICoreWebView2Settings)_Settings;
            }
            set
            {
                _Settings = value;
            }
        }



        public WebView2SettingsInterface(ICoreWebView2Settings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));
            _Settings = settings;
        }

        public int IsScriptEnabled { get => Settings.IsScriptEnabled; set => Settings.IsScriptEnabled = value; }
        public int IsWebMessageEnabled { get => Settings.IsWebMessageEnabled; set => Settings.IsWebMessageEnabled = value; }
        public int AreDefaultScriptDialogsEnabled { get => Settings.AreDefaultScriptDialogsEnabled; set => Settings.AreDefaultScriptDialogsEnabled = value; }
        public int IsStatusBarEnabled { get => Settings.IsStatusBarEnabled; set => Settings.IsStatusBarEnabled = value; }
        public int AreDevToolsEnabled { get => Settings.AreDevToolsEnabled; set => Settings.AreDevToolsEnabled = value; }
        public int AreDefaultContextMenusEnabled { get => Settings.AreDefaultContextMenusEnabled; set => Settings.AreDefaultContextMenusEnabled = value; }
        public int AreHostObjectsAllowed { get => Settings.AreHostObjectsAllowed; set => Settings.AreHostObjectsAllowed = value; }
        public int IsZoomControlEnabled { get => Settings.IsZoomControlEnabled; set => Settings.IsZoomControlEnabled = value; }
        public int IsBuiltInErrorPageEnabled { get => Settings.IsBuiltInErrorPageEnabled; set => Settings.IsBuiltInErrorPageEnabled = value; }

        private bool _IsDisposed;
        protected virtual void Dispose(bool disposing)
        {
            if (_IsDisposed) return;
            if (disposing)
            {
                this.handle.Dispose();
                _Settings = null;
                _IsDisposed = true;
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