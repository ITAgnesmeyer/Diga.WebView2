using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiEnvironment
    {
        public Dictionary<string, string> RequestHeaders { get; }
        public string Path { get; set; }
        public string PathExt { get; set; }
        public string WinDir { get; set; }
        public string SystemRoot { get; set; }
        public string ComSpec { get; set; }
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
        public string RequestScheme { get; set; }
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
        public string HttpHost { get; set; }
        //HTTP_UPGRADE_INSECURE_REQUESTS
        public string HttpUpgradeInsecureRequests { get; set; }
        //HTTP_SEC_FETCH_DEST
        //HTTP_SEC_FETCH_MODE
        //HTTP_SEC_FETCH_SITE
        //HTTP_SEC_FETCH_USER
        public string HttpSecFetchDest { get; set; }
        public string HttpSecFetchMode { get; set; }
        public string HttpSecFetchSite { get; set; }
        public string HttpSecFetchUser { get; set; }

        public string HttpConnection { get; set; }
        public string Referer { get; set; }
        public string TempDir { get; set; }
        public string Temp { get; set; }

        public CgiEnvironment()
        {
            this.RequestHeaders = new Dictionary<string, string>();
            this.GatewayInterface = "CGI/1.1";
            this.ServerProtocol = "HTTP/1.1";
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
            if (value == null) return;
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
            SetVar(info, this.RequestScheme, "REQUEST_SCHEME");
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
            SetVar(info, this.HttpHost, "HTTP_HOST");
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
                else
                {
                    this.HttpAcceptEncoding = "gzip, deflate, br";
                }
            }

            SetVar(info, this.HttpAcceptEncoding, "HTTP_ACCEPT_ENCODING");
            if (string.IsNullOrEmpty(this.HttpAcceptLanguage))
            {
                if (this.RequestHeaders.TryGetValue("Accept-Language", out var acceptLanguage))
                {
                    this.HttpAcceptLanguage = acceptLanguage;
                }
                else
                {
                    this.HttpAcceptLanguage = "de,en-US;q=0.7,en;q=0.3";
                }
            }
            SetVar(info, this.HttpAcceptLanguage, "HTTP_ACCEPT_LANGUAGE");
            if (string.IsNullOrEmpty(this.HttpUserAgent))
            {
                if (this.RequestHeaders.TryGetValue("User-Agent", out var userAgent))
                {
                    this.HttpUserAgent = userAgent;
                }
            }
            SetVar(info,this.HttpUserAgent, "HTTP_USER_AGENT");
            
            if (string.IsNullOrEmpty(this.Referer))
            {
                if (this.RequestHeaders.TryGetValue("Referer", out var referer))
                {
                    this.Referer = referer;
                }
            }

            if (string.IsNullOrEmpty(this.HttpUpgradeInsecureRequests))
            {
                if (this.RequestHeaders.TryGetValue("Upgrade-Insecure-Requests", out var insecRequests))
                {
                    this.HttpUpgradeInsecureRequests = insecRequests;
                }

            }

            SetVar(info, this.HttpUpgradeInsecureRequests, "HTTP_UPGRADE_INSECURE_REQUESTS");

            if (string.IsNullOrEmpty(this.HttpSecFetchDest))
            {
                if (this.RequestHeaders.TryGetValue("Sec-Fetch-Dest", out var secFetchDest))
                {
                    this.HttpSecFetchDest = secFetchDest;
                }
                else
                {
                    this.HttpSecFetchDest = "document";

                }
            }

            SetVar(info, this.HttpSecFetchDest, "HTTP_SEC_FETCH_DEST");


            if (string.IsNullOrEmpty(this.HttpSecFetchMode))
            {
                if (this.RequestHeaders.TryGetValue("Sec-Fetch-Mode", out var secFetchMode))
                {
                    this.HttpSecFetchMode = secFetchMode;
                }
                else
                {
                    this.HttpSecFetchMode = "navigate";
                }
            }

            SetVar(info, this.HttpSecFetchMode, "HTTP_SEC_FETCH_MODE");


            if (string.IsNullOrEmpty(this.HttpSecFetchSite))
            {
                if (this.RequestHeaders.TryGetValue("Sec-Fetch-Site", out var secFetchSite))
                {
                    this.HttpSecFetchSite = secFetchSite;
                }
                else
                {
                    this.HttpSecFetchDest = "none";
                }
            }

            SetVar(info, this.HttpSecFetchSite, "HTTP_SEC_FETCH_SITE");

            if (string.IsNullOrEmpty(this.HttpSecFetchUser))
            {
                if (this.RequestHeaders.TryGetValue("Sec-Fetch-User", out var secFetchuser))
                {
                    this.HttpSecFetchUser = secFetchuser;
                }
                else
                {
                    this.HttpSecFetchUser = "?1";
                }
            }

            SetVar(info, this.HttpSecFetchUser, "HTTP_SEC_FETCH_USER");

            if (string.IsNullOrEmpty(this.HttpConnection))
            {
                this.HttpConnection = "keep-alive";
            }

            SetVar(info, this.HttpConnection, "HTTP_CONNECTION");

            if (string.IsNullOrEmpty(this.Path))
            {
                this.Path = Environment.GetEnvironmentVariable("PATH");
            }

            SetVar(info, this.Path, "PATH");

            if (string.IsNullOrEmpty(this.SystemRoot))
            {
                this.SystemRoot = Environment.GetEnvironmentVariable("SystemRoot");
            }
            SetVar(info, this.SystemRoot, "SystemRoot");


            if (string.IsNullOrEmpty(this.ComSpec))
            {
                this.ComSpec = Environment.GetEnvironmentVariable("ComSpec");
            }
            SetVar(info, this.ComSpec,"COMSPEC");

            if (string.IsNullOrEmpty(this.PathExt))
            {
                this.PathExt = Environment.GetEnvironmentVariable("PATHEXT");
            }

            SetVar(info, this.PathExt, "PATHEXT");


            if (string.IsNullOrEmpty(this.WinDir))
            {
                this.WinDir = Environment.GetEnvironmentVariable("windir");
            }

            SetVar(info, this.WinDir, "WINDIR");

            SetVar(info, this.Referer, "REFERER");
            SetVar(info, this.RemoteUser, "REMOTE_USER");
            SetVar(info, this.ServerSoftware, "SERVER_SOFTWARE");
            SetVar(info, this.TempDir, "TEMPDIR");
            SetVar(info, this.Temp, "TEMP");
            SetVar(info, this.TempDir, "TMP");
            

        }
    }
}