namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the state of a permission in WebView2, matching <c>COREWEBVIEW2_PERMISSION_STATE</c>.
    /// </summary>
    public enum PermissionState
    {
        /// <summary>
        /// The default permission state (not explicitly allowed or denied).
        /// </summary>
        Default,
        /// <summary>
        /// The permission is allowed.
        /// </summary>
        Allow,
        /// <summary>
        /// The permission is denied.
        /// </summary>
        Deny,
    }
}