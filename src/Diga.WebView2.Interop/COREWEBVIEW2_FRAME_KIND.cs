// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_FRAME_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E890F85C-2747-4676-BEB3-566B145AA00D
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2210.55\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of frame in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_FRAME_KIND
    {
        /// <summary>
        /// The frame kind is unknown.
        /// </summary>
        COREWEBVIEW2_FRAME_KIND_UNKNOWN,
        /// <summary>
        /// The main frame of the document.
        /// </summary>
        COREWEBVIEW2_FRAME_KIND_MAIN_FRAME,
        /// <summary>
        /// An iframe element.
        /// </summary>
        COREWEBVIEW2_FRAME_KIND_IFRAME,
        /// <summary>
        /// An embed element.
        /// </summary>
        COREWEBVIEW2_FRAME_KIND_EMBED,
        /// <summary>
        /// An object element.
        /// </summary>
        COREWEBVIEW2_FRAME_KIND_OBJECT,
    }
}
