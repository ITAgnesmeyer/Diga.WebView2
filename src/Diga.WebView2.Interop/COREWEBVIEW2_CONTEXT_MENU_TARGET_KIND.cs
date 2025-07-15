// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of target for a context menu in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND
    {
        /// <summary>
        /// The context menu target is a page.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_PAGE,
        /// <summary>
        /// The context menu target is an image.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_IMAGE,
        /// <summary>
        /// The context menu target is selected text.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_SELECTED_TEXT,
        /// <summary>
        /// The context menu target is audio content.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_AUDIO,
        /// <summary>
        /// The context menu target is video content.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND_VIDEO,
    }
}
