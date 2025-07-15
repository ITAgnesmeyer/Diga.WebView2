// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_KEY_EVENT_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of key event in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_KEY_EVENT_KIND
    {
        /// <summary>
        /// A key down event.
        /// </summary>
        COREWEBVIEW2_KEY_EVENT_KIND_KEY_DOWN,
        /// <summary>
        /// A key up event.
        /// </summary>
        COREWEBVIEW2_KEY_EVENT_KIND_KEY_UP,
        /// <summary>
        /// A system key down event (e.g., ALT key).
        /// </summary>
        COREWEBVIEW2_KEY_EVENT_KIND_SYSTEM_KEY_DOWN,
        /// <summary>
        /// A system key up event (e.g., ALT key).
        /// </summary>
        COREWEBVIEW2_KEY_EVENT_KIND_SYSTEM_KEY_UP,
    }
}
