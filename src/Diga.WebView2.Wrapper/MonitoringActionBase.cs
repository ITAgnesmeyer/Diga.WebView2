using System.IO;

namespace Diga.WebView2.Wrapper
{
    public abstract class MonitoringActionBase:IMonitoringAction
    {
        protected MonitoringActionBase(string monitoringUrl, string monitoringFolder, bool isEnabled, string[] fielExtensions)
        {
            this.MonitoringUrl = monitoringUrl;
            this.MonitoringFolder = monitoringFolder;
            this.IsEnabled = isEnabled;
            this.FielExtensions = fielExtensions;
        }
        public string MonitoringUrl { get; protected set; }
        public string MonitoringFolder { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public string[] FielExtensions { get; protected set; }
        public bool CanExcecute(string url)
        {
            if (!this.IsEnabled)
                return false;
            if (string.IsNullOrEmpty(url))
                return false;
            if (url.StartsWith(this.MonitoringUrl))
                return true;
            return false;
        }

        public abstract bool Run(RequestInfo requestInfo, out ResponseInfo responseInfo);
       

        protected bool MonitoringFileExist(string file)
        {
            if (file.StartsWith("/"))
                file = file.Substring(1);
            file = file.Replace("/", "\\");
            string fullName = Path.Combine(this.MonitoringFolder, file);
            return File.Exists(fullName);
        }

        protected string GetUtf8IfNeeded(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                return "";

            bool needUtf8 = false;

            switch (contentType)
            {
                case "application/x-javascript":
                case "text/html":
                case "text/css":
                case "application/javascript":
                case "application/json":
                    needUtf8 = true;
                    break;
            }

            if (needUtf8)
                return "; charset=utf-8";
            return "";
        }
    }
}