// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_COOKIE_SAME_SITE_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the SameSite attribute for cookies in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_COOKIE_SAME_SITE_KIND
    {
        /// <summary>
        /// No SameSite attribute. The cookie is sent in all contexts, i.e., in responses to both first-party and cross-origin requests.
        /// </summary>
        COREWEBVIEW2_COOKIE_SAME_SITE_KIND_NONE,
        /// <summary>
        /// Lax SameSite attribute. The cookie is not sent on normal cross-site subrequests (for example to load images into a third party site), but is sent when a user is navigating to the origin site (i.e., when following a link).
        /// </summary>
        COREWEBVIEW2_COOKIE_SAME_SITE_KIND_LAX,
        /// <summary>
        /// Strict SameSite attribute. The cookie is only sent in a first-party context and not with requests initiated by third party websites.
        /// </summary>
        COREWEBVIEW2_COOKIE_SAME_SITE_KIND_STRICT,
    }
}
