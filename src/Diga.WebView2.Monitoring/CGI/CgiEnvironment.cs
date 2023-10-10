using System.Collections.Generic;
using System.Diagnostics;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiEnvironment
    {
        public Dictionary<string, string> RequestHeaders { get; }
        public string AuthType { get; set; }
        public string ContentLength { get; set; }
        public string ContentType { get; set; }
        public string GatewayInterface { get; set; }
        public string DocumentRoot { get; set; }
        public string PathInfo { get; set; }
        public string PathTranslated { get; set; }
        public string QueryString { get; set; }
        public string RemoteAddr { get; set; }
        public string RemoteHost { get; set; }
        public string RemotePort { get; set; }
        public string RemoteIdent { get; set; }
        public string RemoteUser { get; set; }
        public string RequestUri { get; set; }
        public string RequestedMethod { get; set; }
        public string RedirectStatus { get; set; }
        public string ScriptName { get; set; }
        public string ScriptFileName { get; set; }
        public string ServerAddr { get; set; }
        public string ServerName { get; set; }
        public string ServerPort { get; set; }
        public string ServerProtocol { get; set; }
        public string ServerSoftware { get; set; }
        public string UserAgent { get; set; }
        public string HttpCookie { get; set; }
        public string HttpAccept { get; set; }
        public string HttpAcceptEncoding { get; set; }
        public string HttpAcceptCharset { get; set; }
        public string HttpAcceptLanguage { get; set; }
        //HTTP_USER_AGENT
        public string HttpUserAgent { get; set; }
        public string Referer { get; set; }
        public string TempDir { get; set; }
        public string Temp { get; set; }

        public CgiEnvironment()
        {
            this.RequestHeaders = new Dictionary<string, string>();
            this.GatewayInterface = "CGI/1.1";
            this.ServerProtocol = "HTTP/1.0";
            this.RedirectStatus = "200";
        }

        public CgiEnvironment(Dictionary<string, string> headers) : this()
        {
            foreach (KeyValuePair<string, string> keyValuePair in headers)
            {
                this.RequestHeaders.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        private void SetVar(ProcessStartInfo info, string value, string name)
        {
            if (string.IsNullOrEmpty(value)) return;
            info.EnvironmentVariables[name] = value;
        }

        public void Set(ProcessStartInfo info)
        {
            info.EnvironmentVariables.Clear();
            SetVar(info, this.GatewayInterface, "GATEWAY_INTERFACE");
            SetVar(info, this.ServerProtocol, "SERVER_PROTOCOL");
            SetVar(info, this.RedirectStatus, "REDIRECT_STATUS");
            SetVar(info, this.DocumentRoot, "DOCUMENT_ROOT");
            SetVar(info, this.ScriptName, "SCRIPT_NAME");
            SetVar(info, this.ScriptFileName, "SCRIPT_FILENAME");
            SetVar(info, this.QueryString, "QUERY_STRING");
            SetVar(info, this.ContentLength, "CONTENT_LENGTH");
            SetVar(info, this.ContentType, "CONTENT_TYPE");
            SetVar(info, this.RequestedMethod, "REQUEST_METHOD");
            SetVar(info, this.RequestUri, "REQUEST_URI");
            SetVar(info, this.UserAgent, "USER_AGENT");
            SetVar(info, this.ServerAddr, "SERVER_ADDR");
            SetVar(info, this.ServerPort, "SERVER_PORT");
            SetVar(info, this.RemoteAddr, "REMOTE_ADDR");
            SetVar(info, this.RemoteHost, "REMOTE_HOST");
            SetVar(info, this.RemotePort, "REMOTE_PORT");
            SetVar(info, this.RemoteIdent, "REMOTE_IDENT");
            SetVar(info, this.ServerName, "SERVER_NAME");
            SetVar(info, this.HttpCookie, "HTTP_COOKIE");
            SetVar(info, this.HttpAccept, "HTTP_ACCEPT");
            SetVar(info, this.HttpAcceptCharset, "HTTP_ACCEPT_CHARSET");
            SetVar(info, this.HttpAcceptEncoding, "HTTP_ACCEPT_ENCODING");
            SetVar(info, this.HttpAcceptLanguage, "HTTP_ACCEPT_LANGUAGE");
            SetVar(info, this.AuthType, "AUTH_TYPE");
            SetVar(info, this.ContentType, "CONTENT_TYPE");
            SetVar(info, this.PathInfo, "PATH_INFO");
            SetVar(info, this.PathTranslated, "PATH_TRANSLATED");
            if (string.IsNullOrEmpty(this.HttpCookie))
            {
                if (this.RequestHeaders.TryGetValue("Cookie", out var coocie))
                {
                    this.HttpCookie = coocie;
                }
            }

            SetVar(info, this.HttpCookie, "HTTP_COOKIE");
            if (string.IsNullOrEmpty(this.HttpAccept))
            {
                if (this.RequestHeaders.TryGetValue("Accept", out var accept))
                {
                    this.HttpAccept = accept;
                }
            }

            this.SetVar(info, this.HttpAccept, "HTTP_ACCEPT");
            if (string.IsNullOrEmpty(this.HttpAcceptCharset))
            {
                if (this.RequestHeaders.TryGetValue("Accept-Charset", out var acceptCharset))
                {
                    this.HttpAcceptCharset = acceptCharset;
                }
            }

            SetVar(info, this.HttpAcceptCharset, "HTTP_ACCEPT_CHARSET");
            if (string.IsNullOrEmpty(this.HttpAcceptEncoding))
            {
                if (this.RequestHeaders.TryGetValue("Accept-Encoding", out var acceptEncoding))
                {
                    this.HttpAcceptEncoding = acceptEncoding;
                }
            }

            SetVar(info, this.HttpAcceptEncoding, "HTTP_ACCEPT_ENCODING");
            if (string.IsNullOrEmpty(this.HttpAcceptLanguage))
            {
                if (this.RequestHeaders.TryGetValue("Accept-Language", out var acceptLanguage))
                {
                    this.HttpAcceptLanguage = acceptLanguage;
                }
            }

            if (string.IsNullOrEmpty(this.HttpUserAgent))
            {
                if (this.RequestHeaders.TryGetValue("User-Agent", out var userAgent))
                {
                    this.HttpUserAgent = userAgent;
                }
            }

            SetVar(info, this.HttpAcceptLanguage, "HTTP_ACCEPT_LANGUAGE");
            if (string.IsNullOrEmpty(this.Referer))
            {
                if (this.RequestHeaders.TryGetValue("Referer", out var referer))
                {
                    this.Referer = referer;
                }
            }

            SetVar(info, this.Referer, "REFERER");
            SetVar(info, this.RemoteUser, "REMOTE_USER");
            SetVar(info, this.ServerSoftware, "SERVER_SOFTWARE");
            SetVar(info, this.TempDir, "TEMPDIR");
            SetVar(info, this.Temp, "TEMP");
            SetVar(info,this.HttpUserAgent, "HTTP_USER_AGENT");

        }
    }
}