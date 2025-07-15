// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_NON_CLIENT_REGION_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of non-client region in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_NON_CLIENT_REGION_KIND
    {
        /// <summary>
        /// The region is not a non-client area.
        /// </summary>
        COREWEBVIEW2_NON_CLIENT_REGION_KIND_NOWHERE,
        /// <summary>
        /// The region is the client area.
        /// </summary>
        COREWEBVIEW2_NON_CLIENT_REGION_KIND_CLIENT,
        /// <summary>
        /// The region is the caption (title bar) area.
        /// </summary>
        COREWEBVIEW2_NON_CLIENT_REGION_KIND_CAPTION,
    }
}
