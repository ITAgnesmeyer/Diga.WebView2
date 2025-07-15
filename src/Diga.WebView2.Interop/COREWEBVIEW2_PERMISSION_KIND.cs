// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PERMISSION_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of permission requested or used in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_PERMISSION_KIND
    {
        /// <summary>
        /// Unknown permission kind.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_UNKNOWN_PERMISSION,
        /// <summary>
        /// Microphone access permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_MICROPHONE,
        /// <summary>
        /// Camera access permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_CAMERA,
        /// <summary>
        /// Geolocation access permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_GEOLOCATION,
        /// <summary>
        /// Notifications permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_NOTIFICATIONS,
        /// <summary>
        /// Other sensors permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_OTHER_SENSORS,
        /// <summary>
        /// Clipboard read permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_CLIPBOARD_READ,
        /// <summary>
        /// Multiple automatic downloads permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_MULTIPLE_AUTOMATIC_DOWNLOADS,
        /// <summary>
        /// File read/write permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_FILE_READ_WRITE,
        /// <summary>
        /// Autoplay permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_AUTOPLAY,
        /// <summary>
        /// Local fonts permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_LOCAL_FONTS,
        /// <summary>
        /// MIDI system exclusive messages permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_MIDI_SYSTEM_EXCLUSIVE_MESSAGES,
        /// <summary>
        /// Window management permission.
        /// </summary>
        COREWEBVIEW2_PERMISSION_KIND_WINDOW_MANAGEMENT,
    }
}
