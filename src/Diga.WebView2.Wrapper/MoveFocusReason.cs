namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the reason for moving focus in WebView2, matching <c>COREWEBVIEW2_MOVE_FOCUS_REASON</c>.
    /// </summary>
    public enum MoveFocusReason
    {
        /// <summary>
        /// Focus was moved programmatically.
        /// </summary>
        Programmatic,
        /// <summary>
        /// Focus was moved to the next element (e.g., via TAB key).
        /// </summary>
        Next,
        /// <summary>
        /// Focus was moved to the previous element (e.g., via SHIFT+TAB).
        /// </summary>
        Previous,
    }
}