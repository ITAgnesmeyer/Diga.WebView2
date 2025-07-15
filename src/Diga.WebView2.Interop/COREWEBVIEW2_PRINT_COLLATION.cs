// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PRINT_COLLATION
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D2204B57-481A-4FA6-AC70-3A20AA2B2B25
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1549-prerelease\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the collation option for printing in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_PRINT_COLLATION
    {
        /// <summary>
        /// Use the default collation setting.
        /// </summary>
        COREWEBVIEW2_PRINT_COLLATION_DEFAULT,
        /// <summary>
        /// Collated printing (pages are grouped by copy).
        /// </summary>
        COREWEBVIEW2_PRINT_COLLATION_COLLATED,
        /// <summary>
        /// Uncollated printing (pages are grouped by page number).
        /// </summary>
        COREWEBVIEW2_PRINT_COLLATION_UNCOLLATED,
    }
}
