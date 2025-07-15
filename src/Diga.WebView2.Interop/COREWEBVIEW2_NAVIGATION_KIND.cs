// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_NAVIGATION_KIND
// Assembly: Diga.WebView2.interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 86C06DAC-1E1B-4B02-A98B-B9D6F676B39A
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1901.177\Diga.WebView2.interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of navigation that occurred in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_NAVIGATION_KIND
    {
        /// <summary>
        /// The navigation was a reload of the current document.
        /// </summary>
        COREWEBVIEW2_NAVIGATION_KIND_RELOAD,
        /// <summary>
        /// The navigation was a back or forward navigation in the history.
        /// </summary>
        COREWEBVIEW2_NAVIGATION_KIND_BACK_OR_FORWARD,
        /// <summary>
        /// The navigation was to a new document.
        /// </summary>
        COREWEBVIEW2_NAVIGATION_KIND_NEW_DOCUMENT,
    }
}
