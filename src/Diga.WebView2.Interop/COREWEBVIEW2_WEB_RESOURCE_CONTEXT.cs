// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_WEB_RESOURCE_CONTEXT
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the context of a web resource request in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_WEB_RESOURCE_CONTEXT
    {
        /// <summary>
        /// All resource types.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_ALL,
        /// <summary>
        /// Document resources (HTML documents).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_DOCUMENT,
        /// <summary>
        /// Stylesheet resources (CSS files).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_STYLESHEET,
        /// <summary>
        /// Image resources (e.g., PNG, JPEG).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_IMAGE,
        /// <summary>
        /// Media resources (audio, video).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_MEDIA,
        /// <summary>
        /// Font resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_FONT,
        /// <summary>
        /// Script resources (JavaScript files).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_SCRIPT,
        /// <summary>
        /// XMLHttpRequest resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_XML_HTTP_REQUEST,
        /// <summary>
        /// Fetch API resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_FETCH,
        /// <summary>
        /// Text track resources (e.g., subtitles).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_TEXT_TRACK,
        /// <summary>
        /// EventSource resources (Server-Sent Events).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_EVENT_SOURCE,
        /// <summary>
        /// WebSocket resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_WEBSOCKET,
        /// <summary>
        /// Manifest resources (e.g., web app manifests).
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_MANIFEST,
        /// <summary>
        /// Signed exchange resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_SIGNED_EXCHANGE,
        /// <summary>
        /// Ping resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_PING,
        /// <summary>
        /// Content Security Policy violation report resources.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_CSP_VIOLATION_REPORT,
        /// <summary>
        /// Other resource types not covered by the above.
        /// </summary>
        COREWEBVIEW2_WEB_RESOURCE_CONTEXT_OTHER,
    }
}
