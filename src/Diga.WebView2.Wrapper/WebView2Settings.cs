using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{

    public class WebView2Settings : WebView2Settings8Interface
    {


        public WebView2Settings(ICoreWebView2Settings8 settings) : base(settings)
        {

        }
        public new bool IsScriptEnabled { get => (CBOOL)base.IsScriptEnabled; set => base.IsScriptEnabled = (CBOOL)value; }
        public new bool IsWebMessageEnabled { get => (CBOOL)base.IsWebMessageEnabled; set => base.IsWebMessageEnabled = (CBOOL)value; }
        public new bool AreDefaultScriptDialogsEnabled { get => (CBOOL)base.AreDefaultScriptDialogsEnabled; 
            set => base.AreDefaultScriptDialogsEnabled = (CBOOL)value; }
        public new bool IsStatusBarEnabled { get => (CBOOL)base.IsStatusBarEnabled; set => base.IsStatusBarEnabled = (CBOOL)value; }
        public new bool AreDevToolsEnabled { get => (CBOOL)base.AreDevToolsEnabled; set => base.AreDevToolsEnabled = (CBOOL)value; }
        public new bool AreDefaultContextMenusEnabled { get => (CBOOL)base.AreDefaultContextMenusEnabled; set => base.AreDefaultContextMenusEnabled = (CBOOL)value; }
        public new bool  AreHostObjectsAllowed { get => (CBOOL)base.AreHostObjectsAllowed; set => base.AreHostObjectsAllowed = (CBOOL)value; }
        public new bool IsZoomControlEnabled { get => (CBOOL)base.IsZoomControlEnabled; set => base.IsZoomControlEnabled = (CBOOL)value; }
        public new bool IsBuiltInErrorPageEnabled { get => (CBOOL)base.IsBuiltInErrorPageEnabled; set => base.IsBuiltInErrorPageEnabled = (CBOOL)value; }
        public new bool IsSwipeNavigationEnabled { get => (CBOOL)base.IsSwipeNavigationEnabled; set => base.IsSwipeNavigationEnabled = (CBOOL)value; }
        public new bool IsPinchZoomEnabled { get => (CBOOL)base.IsPinchZoomEnabled; set => base.IsPinchZoomEnabled = (CBOOL)value; }
        public new bool IsPasswordAutosaveEnabled { get => (CBOOL)base.IsPasswordAutosaveEnabled; set => base.IsPasswordAutosaveEnabled = (CBOOL)value; }
        public new bool IsGeneralAutofillEnabled { get => (CBOOL)base.IsGeneralAutofillEnabled; set => base.IsGeneralAutofillEnabled = (CBOOL)value; }
        public new bool AreBrowserAcceleratorKeysEnabled { get => (CBOOL)base.AreBrowserAcceleratorKeysEnabled; set => base.AreBrowserAcceleratorKeysEnabled = (CBOOL)value; }
        public new COREWEBVIEW2_PDF_TOOLBAR_ITEMS HiddenPdfToolbarItems
        {
            get => base.HiddenPdfToolbarItems;
            set => base.HiddenPdfToolbarItems = value;
        }

        public new bool IsReputationCheckingRequired
        {
            get => (CBOOL)base.IsReputationCheckingRequired;
            set => base.IsReputationCheckingRequired = (CBOOL)value;
        }
       
    }
}