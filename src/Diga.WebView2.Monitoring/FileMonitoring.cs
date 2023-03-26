using System;
using System.Diagnostics;
using System.IO;
using Diga.WebView2.Wrapper;
using MimeTypeExtension;

namespace Diga.WebView2.Monitoring
{
    public class FileMonitoring : MonitoringActionBase
    {
        public FileMonitoring():base("","",false,new string[]{})
        {
            
        }
        public FileMonitoring(string monitoringUrl, string monitoringFolder, bool isEnabled) : base(monitoringUrl, monitoringFolder, isEnabled, new string[]{})
        {
        }

        public void SetMonitoringUrl(string monitoringUrl)
        {
            this.MonitoringUrl = monitoringUrl;
        }

        public void SetMonitoringFolder(string monitoringFlder)
        {
            this.MonitoringFolder = monitoringFlder;
        }

        public void SetIsEnabled(bool isEnabled)
        {
            this.IsEnabled = isEnabled;
        }

        protected string CleanUpFile(string file)
        {
            if (file == "/")
                file = "";
            if (file.StartsWith("/"))
                file = file.Substring(1);
            return file;
        }
        public override bool Run(RequestInfo requestInfo, out ResponseInfo responseInfo)
        {
            string url = requestInfo.Uri;
            if (!CanExcecute(url))
            {
                responseInfo = null;
                return false;
            }

            Uri uri = new Uri(url);


            //TestMimeTypes();
            string baseDirectory = this.MonitoringFolder;

            string file = MonitoringFileExist(uri.AbsolutePath) ? uri.AbsolutePath : "";

            //if (file == "/")
            //    file = "";
            //if (file.StartsWith("/"))
            //    file = file.Substring(1);
            file = CleanUpFile(file);
            if (string.IsNullOrEmpty(file))
                file = "index.html";
            file = file.Replace("/", "\\");
            file = Path.Combine(baseDirectory, file);
            FileInfo fileInfo = new FileInfo(file);
            if (!fileInfo.Exists)
            {
                responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + file + "</h5>");
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type: text/html; charset=utf-8";
                responseInfo.StatusCode = 404;
                responseInfo.StatusText = "Not Found";

                return false;
            }

            string contentType = fileInfo.MimeTypeOrDefault();
            if (contentType == "document")
                Debug.Print(contentType);
            try
            {
                byte[] bytes = File.ReadAllBytes(file);
                responseInfo = new ResponseInfo(bytes);
                string utf8Extension = GetUtf8IfNeeded(contentType);

                responseInfo.Header.Add("content-type", contentType + utf8Extension);

                responseInfo.ContentType = "content-type: " + contentType + utf8Extension;
                responseInfo.StatusCode = 200;
                responseInfo.StatusText = "OK";

                return true;
            }
            catch (Exception e)
            {
                string message = "Error:" + e.Message;
                responseInfo = new ResponseInfo(message);
                responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                responseInfo.ContentType = "content-type; charset=utf-8";
                responseInfo.StatusCode = 500;
                responseInfo.StatusText = "Internal Server Error";
                return true;
            }
        }
    }
}