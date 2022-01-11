using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Implementation;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{

    public class WebView2Settings : WebView2Settings6Interface
    {


        public WebView2Settings(ICoreWebView2Settings6 settings) : base(settings)
        {

        }
        new public bool IsScriptEnabled { get => (CBOOL)base.IsScriptEnabled; set => base.IsScriptEnabled = (CBOOL)value; }
        new public bool IsWebMessageEnabled { get => (CBOOL)base.IsWebMessageEnabled; set => base.IsWebMessageEnabled = (CBOOL)value; }
        new public bool AreDefaultScriptDialogsEnabled { get => (CBOOL)base.AreDefaultScriptDialogsEnabled; set => base.AreDefaultScriptDialogsEnabled = (CBOOL)value; }
        new public bool IsStatusBarEnabled { get => (CBOOL)base.IsStatusBarEnabled; set => base.IsStatusBarEnabled = (CBOOL)value; }
        new public bool AreDevToolsEnabled { get => (CBOOL)base.AreDevToolsEnabled; set => base.AreDevToolsEnabled = (CBOOL)value; }
        new public bool AreDefaultContextMenusEnabled { get => (CBOOL)base.AreDefaultContextMenusEnabled; set => base.AreDefaultContextMenusEnabled = (CBOOL)value; }
        new public bool  AreHostObjectsAllowed { get => (CBOOL)base.AreHostObjectsAllowed; set => base.AreHostObjectsAllowed = (CBOOL)value; }
        new public bool IsZoomControlEnabled { get => (CBOOL)base.IsZoomControlEnabled; set => base.IsZoomControlEnabled = (CBOOL)value; }
        new public bool IsBuiltInErrorPageEnabled { get => (CBOOL)base.IsBuiltInErrorPageEnabled; set => base.IsBuiltInErrorPageEnabled = (CBOOL)value; }
        new public bool IsSwipeNavigationEnabled { get => (CBOOL)base.IsSwipeNavigationEnabled; set => base.IsSwipeNavigationEnabled = (CBOOL)value; }
        new public bool IsPinchZoomEnabled { get => (CBOOL)base.IsPinchZoomEnabled; set => base.IsPinchZoomEnabled = (CBOOL)value; }
        new public bool IsPasswordAutosaveEnabled { get => (CBOOL)base.IsPasswordAutosaveEnabled; set => base.IsPasswordAutosaveEnabled = (CBOOL)value; }
        new public bool IsGeneralAutofillEnabled { get => (CBOOL)base.IsGeneralAutofillEnabled; set => base.IsGeneralAutofillEnabled = (CBOOL)value; }
        new public bool AreBrowserAcceleratorKeysEnabled { get => (CBOOL)base.AreBrowserAcceleratorKeysEnabled; set => base.AreBrowserAcceleratorKeysEnabled = (CBOOL)value; }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}