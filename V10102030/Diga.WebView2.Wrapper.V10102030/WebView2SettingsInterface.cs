using Diga.WebView2.Interop;
using System;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2SettingsInterface : ICoreWebView2Settings,IDisposable
    {
        private  ICoreWebView2Settings _Settings;
        private bool disposedValue;

        public WebView2SettingsInterface(ICoreWebView2Settings settings)
        {
            this._Settings = settings;
        }

        public int IsScriptEnabled { get => _Settings.IsScriptEnabled; set => _Settings.IsScriptEnabled = value; }
        public int IsWebMessageEnabled { get => _Settings.IsWebMessageEnabled; set => _Settings.IsWebMessageEnabled = value; }
        public int AreDefaultScriptDialogsEnabled { get => _Settings.AreDefaultScriptDialogsEnabled; set => _Settings.AreDefaultScriptDialogsEnabled = value; }
        public int IsStatusBarEnabled { get => _Settings.IsStatusBarEnabled; set => _Settings.IsStatusBarEnabled = value; }
        public int AreDevToolsEnabled { get => _Settings.AreDevToolsEnabled; set => _Settings.AreDevToolsEnabled = value; }
        public int AreDefaultContextMenusEnabled { get => _Settings.AreDefaultContextMenusEnabled; set => _Settings.AreDefaultContextMenusEnabled = value; }
        public int AreHostObjectsAllowed { get => _Settings.AreHostObjectsAllowed; set => _Settings.AreHostObjectsAllowed = value; }
        public int IsZoomControlEnabled { get => _Settings.IsZoomControlEnabled; set => _Settings.IsZoomControlEnabled = value; }
        public int IsBuiltInErrorPageEnabled { get => _Settings.IsBuiltInErrorPageEnabled; set => _Settings.IsBuiltInErrorPageEnabled = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._Settings = null;
                }

                // TODO: Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                // TODO: Große Felder auf NULL setzen
                disposedValue = true;
            }
        }

        // // TODO: Finalizer nur überschreiben, wenn "Dispose(bool disposing)" Code für die Freigabe nicht verwalteter Ressourcen enthält
        // ~WebView2SettingsInterface()
        // {
        //     // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in der Methode "Dispose(bool disposing)" ein.
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}