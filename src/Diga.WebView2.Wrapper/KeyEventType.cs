namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the kind of key event in WebView2, matching <c>COREWEBVIEW2_KEY_EVENT_KIND</c>.
    /// </summary>
    public enum KeyEventType
    {
        /// <summary>
        /// A key down event.
        /// </summary>
        KeyDown,
        /// <summary>
        /// A key up event.
        /// </summary>
        KeyUp,
        /// <summary>
        /// A system key down event (e.g., ALT key).
        /// </summary>
        SystemKeyDown,
        /// <summary>
        /// A system key up event (e.g., ALT key).
        /// </summary>
        SystemKeyUp,
    }
}