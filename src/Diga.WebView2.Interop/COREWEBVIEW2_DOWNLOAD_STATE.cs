// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_DOWNLOAD_STATE
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the state of a download in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_DOWNLOAD_STATE
    {
        /// <summary>
        /// The download is currently in progress.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_STATE_IN_PROGRESS,
        /// <summary>
        /// The download was interrupted.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_STATE_INTERRUPTED,
        /// <summary>
        /// The download has completed successfully.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_STATE_COMPLETED,
    }
}
