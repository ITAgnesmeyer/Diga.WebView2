// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Specifies the reason why a download was interrupted in WebView2.
    /// </summary>
    public enum COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON
    {
        /// <summary>
        /// No interruption occurred.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NONE,
        /// <summary>
        /// The file operation failed.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_FAILED,
        /// <summary>
        /// File access was denied.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_ACCESS_DENIED,
        /// <summary>
        /// There was not enough disk space.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_NO_SPACE,
        /// <summary>
        /// The file name was too long.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_NAME_TOO_LONG,
        /// <summary>
        /// The file was too large.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_TOO_LARGE,
        /// <summary>
        /// The file was determined to be malicious.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_MALICIOUS,
        /// <summary>
        /// A transient file error occurred.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_TRANSIENT_ERROR,
        /// <summary>
        /// The file was blocked by policy.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_BLOCKED_BY_POLICY,
        /// <summary>
        /// The file security check failed.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_SECURITY_CHECK_FAILED,
        /// <summary>
        /// The file was too short.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_TOO_SHORT,
        /// <summary>
        /// The file hash did not match.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_FILE_HASH_MISMATCH,
        /// <summary>
        /// A network failure occurred.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NETWORK_FAILED,
        /// <summary>
        /// The network operation timed out.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NETWORK_TIMEOUT,
        /// <summary>
        /// The network was disconnected.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NETWORK_DISCONNECTED,
        /// <summary>
        /// The network server was down.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NETWORK_SERVER_DOWN,
        /// <summary>
        /// The network request was invalid.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_NETWORK_INVALID_REQUEST,
        /// <summary>
        /// The server operation failed.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_FAILED,
        /// <summary>
        /// The server did not support range requests.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_NO_RANGE,
        /// <summary>
        /// The server returned bad content.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_BAD_CONTENT,
        /// <summary>
        /// The server did not authorize the request.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_UNAUTHORIZED,
        /// <summary>
        /// There was a problem with the server certificate.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_CERTIFICATE_PROBLEM,
        /// <summary>
        /// The server forbade the request.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_FORBIDDEN,
        /// <summary>
        /// The server returned an unexpected response.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_UNEXPECTED_RESPONSE,
        /// <summary>
        /// The server content length did not match.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_CONTENT_LENGTH_MISMATCH,
        /// <summary>
        /// The server performed a cross-origin redirect.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_SERVER_CROSS_ORIGIN_REDIRECT,
        /// <summary>
        /// The user canceled the download.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_USER_CANCELED,
        /// <summary>
        /// The user shut down the browser.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_USER_SHUTDOWN,
        /// <summary>
        /// The user paused the download.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_USER_PAUSED,
        /// <summary>
        /// The download process crashed.
        /// </summary>
        COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON_DOWNLOAD_PROCESS_CRASHED,
    }
}
