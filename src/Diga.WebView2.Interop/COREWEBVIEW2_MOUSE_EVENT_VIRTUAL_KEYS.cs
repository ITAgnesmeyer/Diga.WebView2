// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the virtual key states for mouse events in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS
    {
        /// <summary>
        /// No virtual key is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_NONE = 0,
        /// <summary>
        /// The left mouse button is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_LEFT_BUTTON = 1,
        /// <summary>
        /// The right mouse button is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_RIGHT_BUTTON = 2,
        /// <summary>
        /// The SHIFT key is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_SHIFT = 4,
        /// <summary>
        /// The CONTROL key is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_CONTROL = 8,
        /// <summary>
        /// The middle mouse button is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_MIDDLE_BUTTON = 16, // 0x00000010
        /// <summary>
        /// The first X mouse button is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON1 = 32, // 0x00000020
        /// <summary>
        /// The second X mouse button is pressed.
        /// </summary>
        COREWEBVIEW2_MOUSE_EVENT_VIRTUAL_KEYS_X_BUTTON2 = 64, // 0x00000040
    }
}
