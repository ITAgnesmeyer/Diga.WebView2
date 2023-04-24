using System;
using System.Collections.Generic;
using System.IO;
using Diga.WebView2.Wrapper;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiMoitoring : FileMonitoring
    {
        public string CgiExecutable { get; set; }
        public string[] CgiExtionsions { get; set; }
        public CgiMoitoring()
        {
            
        }
        public CgiMoitoring(string monitoringUrl, string monitoringFolder, bool isEnabled, string[] fielExtensions) : base(monitoringUrl, monitoringFolder, isEnabled)
        {
            this.CgiExtionsions = fielExtensions;
        }




        public void SetCgiExeFile(string file)
        {
            this.CgiExecutable = file;
        }

        public void SetCgiExtionsions(string[] extionsions)
        {
            this.CgiExtionsions = extionsions;
        }
        private CgiMethod GetMethod(string value)
        {
            switch (value)
            {
                case "GET": return CgiMethod.GET;
                case "POST": return CgiMethod.POST;
                case "PUT": return CgiMethod.PUT;
                case "DELETE": return CgiMethod.DELETE;
                case "HEAD": return CgiMethod.HEAD;
            }

            return CgiMethod.GET;
        }

        private string GetContentTypeFromHeader(RequestInfo requestInfo)
        {
            if (requestInfo == null)
            {
                return "text/html";
            }

            foreach (KeyValuePair<string,string> header in requestInfo.Headers)
            {
                if (header.Key == "Content-Type")
                {
                    return header.Value;
                }
            }

            return "text/html";
        }
        public override bool Run(RequestInfo requestInfo, out ResponseInfo responseInfo)
        {
            if (!CanExcecute(requestInfo.Uri))
            {
                responseInfo = null;
                return false;
            }
            FileInfo exeInfo = new FileInfo(this.CgiExecutable);
            if (!exeInfo.Exists)
            {
                responseInfo = null;
                return false;
            }

            if (!CheckCgiExtension(requestInfo))
            {
                return base.Run(requestInfo, out responseInfo);
            }

            string conentType = GetContentTypeFromHeader(requestInfo);

            CgiEnvironment env = new CgiEnvironment(requestInfo.Headers)
            {
                ContentType = conentType,
                RequestedMethod = requestInfo.Method,
                
            };
            CgiInvoker invoker = new CgiInvoker
            {
                CgiExe = exeInfo.FullName,
                ScriptBasePath = this.MonitoringFolder
            };
            string content = requestInfo.Content;
            string query = requestInfo.Uri;
            if (conentType == "application/x-www-form-urlencoded")
            {
                if (query.EndsWith("/"))
                {
                    query = query.Substring(0, query.Length - 1);

                    query = query + "?" + content;
                    //content = string.Empty;
                }
            }

            CgiResponse respose = invoker.Send(GetMethod(requestInfo.Method), conentType, query, env,
                content);

            if (respose != null)
            {
                responseInfo = new ResponseInfo(respose.Body);
                responseInfo.ContentType = env.ContentType;
                string status = "200 OK";
                foreach (KeyValuePair<string, string> resposeHeader in respose.Headers)
                {
                    if (resposeHeader.Key != "Status")
                    {
                        if (responseInfo.Header.ContainsKey(resposeHeader.Key))
                        {
                            responseInfo.Header[resposeHeader.Key] = resposeHeader.Value;
                        }
                        else
                        {
                            responseInfo.Header.Add(resposeHeader.Key, resposeHeader.Value);    
                        }
                        
                        if (resposeHeader.Key == "Content-type")
                        {
                            responseInfo.ContentType = resposeHeader.Value;
                        }
                    }
                    else
                    {
                        status = resposeHeader.Value;
                    }
                }

                CgiStatus st = new CgiStatus(status);

                responseInfo.StatusCode = st.Status;
                responseInfo.StatusText = st.StatusMessage;
                return true;

            }

            return base.Run(requestInfo, out responseInfo);
        }

        private bool CheckCgiExtension(RequestInfo requestInfo)
        {
            string url = requestInfo.Uri;
            if (url == null)
                return false;
            if (url.EndsWith("/")) 
                url = url.Substring(0, url.Length - 1);
            Uri ur = new Uri(url);
            string lPath = ur.LocalPath;
            if(lPath.StartsWith("/"))
                lPath = lPath.Substring(1);
            lPath = lPath.Replace("/", "\\");
            if (string.IsNullOrEmpty(lPath))
                return false;
            FileInfo fi = new FileInfo(lPath);
            string ext = fi.Extension;
            if (string.IsNullOrEmpty(ext))
                return false;
            if(ext.StartsWith("."))
                ext = ext.Substring(1);
            ext = ext.ToLower();
            foreach (string cgiExtionsion in this.CgiExtionsions)
            {
                if (!string.IsNullOrEmpty(cgiExtionsion))
                {

                    if (cgiExtionsion.ToLower().Trim().Equals(ext))
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}