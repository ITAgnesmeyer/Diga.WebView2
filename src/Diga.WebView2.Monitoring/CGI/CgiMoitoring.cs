using System;
using System.Collections.Generic;
using System.IO;
using Diga.WebView2.Wrapper;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiStatus
    {
        private string _statusString;
        public int Status { get; private set; }
        public string StatusMessage { get; private set; }
        public CgiStatus(string statusString)
        {
            this._statusString = statusString;
            SetValues();
        }

        private void SetValues()
        {
            if (this._statusString != null)
            {
                int firstIndex = this._statusString.IndexOf(" ", StringComparison.Ordinal);
                if (firstIndex > 0)
                {
                    string st = this._statusString.Substring(0, firstIndex);
                    string stv = this._statusString.Substring(firstIndex);
                    if (int.TryParse(st, out int s))
                    {
                        this.Status = s;
                        this.StatusMessage = stv.Trim();
                    }
                }
            }
                

        }
    }
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

            string conentType = GetContentTypeFromHeader(requestInfo);

            CgiEnvironment env = new CgiEnvironment(requestInfo.Headers)
            {
                ContentType = conentType,
                RequestedMethod = requestInfo.Method,
                
            };
            CgiInvoker invoker = new CgiInvoker();
            invoker.CgiExe = exeInfo.FullName;
            invoker.ScriptBasePath = this.MonitoringFolder;
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
                        responseInfo.Header.Add(resposeHeader.Key, resposeHeader.Value);
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
    }
}