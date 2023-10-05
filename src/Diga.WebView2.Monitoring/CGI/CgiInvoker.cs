using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System;
using System.Linq;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiInvoker
    {
        public string CgiExe { get; set; }
        public string ScriptBasePath { get; set; }
        public string RepsponseContent { get; private set; }

        private string GetHostAddress(string host)
        {
            var first = Dns.GetHostEntry(host).AddressList
                .First(addr => addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return first?.ToString();
        }

        private string GetQueryString(Uri uri)
        {
            if(string.IsNullOrEmpty(uri.Query))
                return string.Empty;
            if(uri.Query.Length <=1)
                return string.Empty;

            var query = uri.Query.Substring(1);
            return query;

        }
        public CgiResponse Send(CgiMethod mehtod, string contentType, string query, CgiEnvironment environment,
            string body)
        {
            this.RepsponseContent = "";
            Process p = new Process();
            p.StartInfo.FileName = this.CgiExe;
            Uri uri = new Uri(query);
            string scriptPath = uri.AbsolutePath;
            if (scriptPath.StartsWith("/")) scriptPath = scriptPath.Substring(1);
            scriptPath = scriptPath.Replace("/", "\\");
            scriptPath = Path.Combine(ScriptBasePath, scriptPath);
            ManualResetEvent mrs = new ManualResetEvent(false);
            p.Exited += (o, e) => { mrs.Set(); };
            p.StartInfo.Arguments = scriptPath;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.WorkingDirectory = this.ScriptBasePath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            environment.DocumentRoot = this.ScriptBasePath.Replace("\\", "/");
            if (!environment.DocumentRoot.EndsWith("/")) environment.DocumentRoot += "/";
            environment.PathInfo = "/";
            environment.ContentLength = body.Length.ToString();
            environment.RequestedMethod = mehtod.ToString();
            environment.QueryString = GetQueryString(uri);
            if (!string.IsNullOrEmpty(environment.QueryString))
            {
                string args = environment.QueryString.Replace("&", " ");
                //p.StartInfo.Arguments += " " + args;
            }
            FileInfo info = new FileInfo(scriptPath);
            string scriptFilePath = info.FullName;
            string scriptFileName = info.Name;
            string scriptFolderPath = info.DirectoryName;
            string tempPath = Path.GetTempPath();
            environment.ScriptName = scriptFileName;
            environment.ScriptFileName = scriptFilePath;
            environment.ServerAddr = GetHostAddress(uri.Host);
            environment.ServerPort = uri.Port.ToString();
            environment.RemoteAddr = GetHostAddress(uri.Host);
            environment.RemotePort = uri.Port.ToString();
            environment.RequestUri = uri.AbsoluteUri;
            environment.ContentType = contentType;
            environment.Set(p.StartInfo);
            p.EnableRaisingEvents = true;

    //throw new Exception("NET8.0 cannot run Process.Start()");
            string fwDesk = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            if (fwDesk != null)
            {
                if (fwDesk.StartsWith(".NET 8.0.0"))
                {
                    throw new Exception("NET8.0 currently cannot run Process.Start()");
                }
            }

            p.Start();

            StreamWriter sw = p.StandardInput;
            sw.Write(body);
            sw.Flush();
            StreamReader sr = p.StandardOutput;
            this.RepsponseContent = sr.ReadToEnd();
            sr.Close();
            mrs.WaitOne(10000);
            return new CgiResponse(this.RepsponseContent);
        }
    }
}