namespace Diga.WebView2.Wrapper
{
    public enum ErrorStatus
    {
        Unknown,
        CertificateCommonNameIsIincorrect,
        CertificateExpired,
        Client_CertificateContiansError,
        CertificateRevoked,
        CertificateIsInvalid,
        ServerUnreachable,
        Timeout,
        ErroHttpInvalidServerResponse,
        ConnectionAbborted,
        ConnectionReset,
        Disconnected,
        CannotConnect,
        HostNameNot_Resolved,
        OperationCanceled,
        RedirectFailed,
        UnexpectedError
    }
}