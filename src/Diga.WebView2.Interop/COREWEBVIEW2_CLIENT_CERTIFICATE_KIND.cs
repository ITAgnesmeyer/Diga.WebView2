// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_CLIENT_CERTIFICATE_KIND
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the kind of client certificate used in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_CLIENT_CERTIFICATE_KIND
    {
        /// <summary>
        /// The client certificate is stored on a smart card.
        /// </summary>
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_SMART_CARD,
        /// <summary>
        /// The client certificate is protected by a PIN.
        /// </summary>
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_PIN,
        /// <summary>
        /// The client certificate is of another kind.
        /// </summary>
        COREWEBVIEW2_CLIENT_CERTIFICATE_KIND_OTHER,
    }
}
