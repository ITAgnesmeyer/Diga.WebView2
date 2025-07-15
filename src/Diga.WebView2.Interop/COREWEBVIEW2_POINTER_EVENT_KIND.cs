// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_POINTER_EVENT_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of pointer event in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_POINTER_EVENT_KIND
    {
        /// <summary>
        /// Pointer update event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_UPDATE = 581, // 0x00000245
        /// <summary>
        /// Pointer down event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_DOWN = 582, // 0x00000246
        /// <summary>
        /// Pointer up event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_UP = 583, // 0x00000247
        /// <summary>
        /// Pointer enter event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_ENTER = 585, // 0x00000249
        /// <summary>
        /// Pointer leave event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_LEAVE = 586, // 0x0000024A
        /// <summary>
        /// Pointer activate event.
        /// </summary>
        COREWEBVIEW2_POINTER_EVENT_KIND_ACTIVATE = 587, // 0x0000024B
    }
}
