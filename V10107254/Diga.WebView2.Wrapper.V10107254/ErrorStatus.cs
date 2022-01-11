namespace Diga.WebView2.Wrapper
{
    public enum ErrorStatus
    {
        Unknown,
        CertificateCommonNameIsIincorrect,
        CertificateExpired,
        ClientCertificateContiansError,
        CertificateRevoked,
        CertificateIsInvalid,
        ServerUnreachable,
        Timeout,
        ErroHttpInvalidServerResponse,
        ConnectionAbborted,
        ConnectionReset,
        Disconnected,
        CannotConnect,
        HostNameNotResolved,
        OperationCanceled,
        RedirectFailed,
        UnexpectedError
    }
}