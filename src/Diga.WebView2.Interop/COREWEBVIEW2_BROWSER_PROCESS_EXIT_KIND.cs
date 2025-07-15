// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78A35386-8488-46E1-BA73-85C815D94A35
// Assembly location: O:\webview2\V1099228\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the reason why the browser process for WebView2 exited.
    /// </summary>
    public enum COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND
    {
        /// <summary>
        /// The browser process exited normally.
        /// </summary>
        COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND_NORMAL,
        /// <summary>
        /// The browser process exited due to a failure.
        /// </summary>
        COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND_FAILED,
    }
}
