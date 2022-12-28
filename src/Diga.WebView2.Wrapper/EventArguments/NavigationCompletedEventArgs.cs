using System;

namespace Diga.WebView2.Wrapper.EventArguments
{
    public class NavigationCompletedEventArgs : EventArgs
    {
        public NavigationCompletedEventArgs(ErrorStatus webErrorStatus, bool isSuccess, ulong navigationId)
        {
            this.WebErrorStatus = webErrorStatus;
            this.IsSuccess = isSuccess;
            this.NavigationId = navigationId;
        }

        public ErrorStatus WebErrorStatus{get;}
        public bool IsSuccess{get;}
        public ulong NavigationId { get; }

        public string GetErrorText()
        {
            switch (this.WebErrorStatus)
            {
                case ErrorStatus.CannotConnect:
                    return "Cannot connect";
                case ErrorStatus.CertificateCommonNameIsIincorrect:
                    return "Certificate common name is incorrect";
                case ErrorStatus.CertificateExpired:
                    return "Certificate expired";
                case ErrorStatus.CertificateIsInvalid:
                    return "Certificate is invalid";
                case ErrorStatus.CertificateRevoked:
                    return "Certificate revoked";
                case ErrorStatus.ClientCertificateContiansError:
                    return "Client certificate contians error";
                case ErrorStatus.ConnectionAbborted:
                    return "Connection abborted";
                case ErrorStatus.ConnectionReset:
                    return "Connection reset";
                case ErrorStatus.Disconnected:
                    return "Disconnected";
                case ErrorStatus.ErroHttpInvalidServerResponse:
                    return "Error http invalid server response";
                case ErrorStatus.HostNameNotResolved:
                    return "Hostname not resolved";
                case ErrorStatus.OperationCanceled:
                    return "Operation canceled";
                case ErrorStatus.RedirectFailed:
                    return "Redirect failed";
                case ErrorStatus.ServerUnreachable:
                    return "Server unreachable";
                case ErrorStatus.Timeout:
                    return "Timeout";
                case ErrorStatus.UnexpectedError:
                    return "Unexpected error";
                case ErrorStatus.Unknown:
                    return "Unknown error";
                case ErrorStatus.ValidAuthenticationCredentialsRequired:
                    return "Valid Authentication Credentials Required";
                case ErrorStatus.ValidProxyAuthenticationRequired:
                    return "Valid Proxy Authentication Required";
            }

            return "";
        }
    }
}