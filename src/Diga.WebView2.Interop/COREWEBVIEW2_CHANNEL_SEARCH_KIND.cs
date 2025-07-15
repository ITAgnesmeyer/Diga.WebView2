// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_CHANNEL_SEARCH_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of channel search to perform for WebView2 installations.
    /// </summary>
    public enum COREWEBVIEW2_CHANNEL_SEARCH_KIND
    {
        /// <summary>
        /// Search for the most stable channel (e.g., release channel).
        /// </summary>
        COREWEBVIEW2_CHANNEL_SEARCH_KIND_MOST_STABLE,
        /// <summary>
        /// Search for the least stable channel (e.g., canary or dev channel).
        /// </summary>
        COREWEBVIEW2_CHANNEL_SEARCH_KIND_LEAST_STABLE,
    }
}
