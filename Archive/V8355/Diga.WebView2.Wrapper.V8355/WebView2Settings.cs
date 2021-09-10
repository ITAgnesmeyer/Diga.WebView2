using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings : IWebView2Settings2
    {
        private IWebView2Settings2 _Settings;

        public WebView2Settings(IWebView2Settings2 settings)
        {
            this._Settings = settings;
        }
        public int IsScriptEnabled
        {
            get => this._Settings.IsScriptEnabled;
            set => this._Settings.IsScriptEnabled = value;
        }

        public int IsWebMessageEnabled
        {
            get => this._Settings.IsWebMessageEnabled;
            set => this._Settings.IsWebMessageEnabled = value;
        }

        public int AreDefaultScriptDialogsEnabled
        {
            get => this._Settings.AreDefaultScriptDialogsEnabled;
            set => this._Settings.AreDefaultScriptDialogsEnabled = value;
        }

        public int IsFullscreenAllowed_deprecated
        {
            get => this._Settings.IsFullscreenAllowed_deprecated;
            set => this._Settings.IsFullscreenAllowed_deprecated = value;
        }

        public int IsStatusBarEnabled
        {
            get => this._Settings.IsStatusBarEnabled;
            set => this._Settings.IsStatusBarEnabled = value;
        }

        public int AreDevToolsEnabled
        {
            get => this._Settings.AreDevToolsEnabled;
            set => this._Settings.AreDevToolsEnabled=value;
        }

        public int AreDefaultContextMenusEnabled
        {
            get => this._Settings.AreDefaultContextMenusEnabled;
            set => this._Settings.AreDefaultContextMenusEnabled = value;
        }

        //public int AreRemoteObjectsAllowed
        //{
        //    get => this._Settings.AreRemoteObjectsAllowed;
        //    set => this._Settings.AreRemoteObjectsAllowed = value;
        //}

        //public int IsZoomControlEnabled
        //{
        //    get => this._Settings.IsZoomControlEnabled;
        //    set => this._Settings.IsZoomControlEnabled = value;
        //}
    }
}