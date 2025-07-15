// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_MOVE_FOCUS_REASON
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the reason for moving focus in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_MOVE_FOCUS_REASON
    {
        /// <summary>
        /// Focus was moved programmatically.
        /// </summary>
        COREWEBVIEW2_MOVE_FOCUS_REASON_PROGRAMMATIC,
        /// <summary>
        /// Focus was moved to the next element (e.g., via TAB key).
        /// </summary>
        COREWEBVIEW2_MOVE_FOCUS_REASON_NEXT,
        /// <summary>
        /// Focus was moved to the previous element (e.g., via SHIFT+TAB).
        /// </summary>
        COREWEBVIEW2_MOVE_FOCUS_REASON_PREVIOUS,
    }
}
