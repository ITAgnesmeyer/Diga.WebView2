// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_PERMISSION_STATE
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the state of a permission in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_PERMISSION_STATE
    {
        /// <summary>
        /// The default permission state (not explicitly allowed or denied).
        /// </summary>
        COREWEBVIEW2_PERMISSION_STATE_DEFAULT,
        /// <summary>
        /// The permission is allowed.
        /// </summary>
        COREWEBVIEW2_PERMISSION_STATE_ALLOW,
        /// <summary>
        /// The permission is denied.
        /// </summary>
        COREWEBVIEW2_PERMISSION_STATE_DENY,
    }
}
