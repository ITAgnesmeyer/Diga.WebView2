// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of host resource access for WebView2.
    /// </summary>
    public enum COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND
    {
        /// <summary>
        /// Deny access to the host resource.
        /// </summary>
        COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND_DENY,
        /// <summary>
        /// Allow access to the host resource.
        /// </summary>
        COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND_ALLOW,
        /// <summary>
        /// Deny access to the host resource for CORS requests.
        /// </summary>
        COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND_DENY_CORS,
    }
}
