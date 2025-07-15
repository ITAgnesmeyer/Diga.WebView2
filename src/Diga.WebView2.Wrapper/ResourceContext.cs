namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the context of a web resource request, matching <c>COREWEBVIEW2_WEB_RESOURCE_CONTEXT</c>.
    /// </summary>
    public enum ResourceContext
    {
        /// <summary>
        /// All resource types.
        /// </summary>
        All,
        /// <summary>
        /// Document resources (HTML documents).
        /// </summary>
        Document,
        /// <summary>
        /// Stylesheet resources (CSS files).
        /// </summary>
        Stylesheet,
        /// <summary>
        /// Image resources (e.g., PNG, JPEG).
        /// </summary>
        Image,
        /// <summary>
        /// Media resources (audio, video).
        /// </summary>
        Media,
        /// <summary>
        /// Font resources.
        /// </summary>
        Font,
        /// <summary>
        /// Script resources (JavaScript files).
        /// </summary>
        Script,
        /// <summary>
        /// XMLHttpRequest resources.
        /// </summary>
        XmlHttpRequest,
        /// <summary>
        /// Fetch API resources.
        /// </summary>
        Fetch,
        /// <summary>
        /// Text track resources (e.g., subtitles).
        /// </summary>
        TextTrack,
        /// <summary>
        /// EventSource resources (Server-Sent Events).
        /// </summary>
        EventSource,
        /// <summary>
        /// WebSocket resources.
        /// </summary>
        WebSocket,
        /// <summary>
        /// Manifest resources (e.g., web app manifests).
        /// </summary>
        Manifest,
        /// <summary>
        /// Signed exchange resources.
        /// </summary>
        SignedExchange,
        /// <summary>
        /// Ping resources.
        /// </summary>
        Ping,
        /// <summary>
        /// Content Security Policy violation report resources.
        /// </summary>
        CspViolationReport,
        /// <summary>
        /// Other resource types not covered by the above.
        /// </summary>
        Other,
    }
}