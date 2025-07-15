namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the web error status, matching <c>COREWEBVIEW2_WEB_ERROR_STATUS</c>.
    /// </summary>
    public enum ErrorStatus
    {
        /// <summary>
        /// Unknown error.
        /// </summary>
        Unknown,
        /// <summary>
        /// The certificate common name is incorrect.
        /// </summary>
        CertificateCommonNameIsIncorrect,
        /// <summary>
        /// The certificate has expired.
        /// </summary>
        CertificateExpired,
        /// <summary>
        /// The client certificate contains errors.
        /// </summary>
        ClientCertificateContainsErrors,
        /// <summary>
        /// The certificate has been revoked.
        /// </summary>
        CertificateRevoked,
        /// <summary>
        /// The certificate is invalid.
        /// </summary>
        CertificateIsInvalid,
        /// <summary>
        /// The server is unreachable.
        /// </summary>
        ServerUnreachable,
        /// <summary>
        /// The request timed out.
        /// </summary>
        Timeout,
        /// <summary>
        /// The server response is invalid (HTTP error).
        /// </summary>
        ErrorHttpInvalidServerResponse,
        /// <summary>
        /// The connection was aborted.
        /// </summary>
        ConnectionAborted,
        /// <summary>
        /// The connection was reset.
        /// </summary>
        ConnectionReset,
        /// <summary>
        /// Disconnected from the server.
        /// </summary>
        Disconnected,
        /// <summary>
        /// Cannot connect to the server.
        /// </summary>
        CannotConnect,
        /// <summary>
        /// The host name could not be resolved.
        /// </summary>
        HostNameNotResolved,
        /// <summary>
        /// The operation was canceled.
        /// </summary>
        OperationCanceled,
        /// <summary>
        /// The redirect failed.
        /// </summary>
        RedirectFailed,
        /// <summary>
        /// An unexpected error occurred.
        /// </summary>
        UnexpectedError,
        /// <summary>
        /// Valid authentication credentials are required.
        /// </summary>
        ValidAuthenticationCredentialsRequired,
        /// <summary>
        /// Valid proxy authentication credentials are required.
        /// </summary>
        ValidProxyAuthenticationRequired
    }
}