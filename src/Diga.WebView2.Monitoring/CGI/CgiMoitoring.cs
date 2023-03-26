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


            return base.Run(requestInfo, out responseInfo);
        }
    }
}