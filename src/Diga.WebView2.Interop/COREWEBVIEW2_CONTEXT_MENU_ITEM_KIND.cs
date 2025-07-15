// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of context menu item in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND
    {
        /// <summary>
        /// A command menu item.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_COMMAND,
        /// <summary>
        /// A check box menu item.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_CHECK_BOX,
        /// <summary>
        /// A radio button menu item.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_RADIO,
        /// <summary>
        /// A separator menu item.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_SEPARATOR,
        /// <summary>
        /// A submenu item.
        /// </summary>
        COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND_SUBMENU,
    }
}
