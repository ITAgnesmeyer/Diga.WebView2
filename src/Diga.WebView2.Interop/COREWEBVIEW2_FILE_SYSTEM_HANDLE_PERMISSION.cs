// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the permission level for a file system handle in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION
    {
        /// <summary>
        /// The handle has read-only permission.
        /// </summary>
        COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION_READ_ONLY,
        /// <summary>
        /// The handle has read and write permission.
        /// </summary>
        COREWEBVIEW2_FILE_SYSTEM_HANDLE_PERMISSION_READ_WRITE,
    }
}
