using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    public class WebView2Settings : ICoreWebView2Settings6
    {
        private readonly ICoreWebView2Settings6 _Settings;

        public WebView2Settings(ICoreWebView2Settings6 settings)
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

       

        public int AreHostObjectsAllowed
        {
            get => this._Settings.AreHostObjectsAllowed;
            set => this._Settings.AreHostObjectsAllowed = value;
        }

        public int IsZoomControlEnabled
        {
            get => this._Settings.IsZoomControlEnabled;
            set => this._Settings.IsZoomControlEnabled = value;
        }

        public int IsBuiltInErrorPageEnabled
        {
            get => this._Settings.IsBuiltInErrorPageEnabled;
            set => this._Settings.IsBuiltInErrorPageEnabled = value;
        }

        public string UserAgent
        {
            get => this._Settings.UserAgent;
            set => this._Settings.UserAgent = value;
        }

        public int AreBrowserAcceleratorKeysEnabled
        {
            get=> this._Settings.AreBrowserAcceleratorKeysEnabled; 
            set=> this._Settings.AreBrowserAcceleratorKeysEnabled = value;
        }

        public int IsPasswordAutosaveEnabled
        {
            get => this._Settings.IsPasswordAutosaveEnabled;
            set => this._Settings.IsPasswordAutosaveEnabled = value;
        }

        public int IsGeneralAutofillEnabled
        {
            get => this._Settings.IsGeneralAutofillEnabled;
            set => this._Settings.IsGeneralAutofillEnabled = value;
        }

        public int IsPinchZoomEnabled
        {
            get => this._Settings.IsPinchZoomEnabled;
            set => this._Settings.IsPinchZoomEnabled = value;
        }
        public int IsSwipeNavigationEnabled 
        { 
            get => this._Settings.IsSwipeNavigationEnabled; 
            set => this._Settings.IsStatusBarEnabled = value; 
        }
    }
}