using System;
using Diga.WebView2.Wrapper;

namespace Diga.WebView2.Monitoring
{
    public class ResourceMonitoring : MonitoringActionBase
    {
        public ResourceMonitoring( bool isEnabled) : base("diga://", "", isEnabled, new string[]{})
        {
        }

        public override bool Run(RequestInfo requestInfo, out ResponseInfo responseInfo)
        {
            string url = requestInfo.Uri;
            string monUrl = this.MonitoringUrl;

            if (!url.StartsWith(monUrl))
            {
                responseInfo = null;
                return false;
            }

            if (url.Length <= monUrl.Length)
            {
                responseInfo = null;
                return false;
            }
            Uri uri = new Uri(url);
            string resName = uri.Authority + uri.AbsolutePath;

            if (string.IsNullOrEmpty(resName))
            {
                responseInfo = null;
                return false;
            }

            try
            {
                

                string resString = WebResoruces.ResourceManager.GetString(resName);
                if (resString == null)
                {
                    responseInfo = new ResponseInfo("<h1>Server Error</h1><h5>file not found:" + url + "</h5>");
                    responseInfo.Header.Add("content-type", "text/html; charset=utf-8");
                    responseInfo.ContentType = "content-type: text/html; charset=utf-8";
                    responseInfo.StatusCode = 404;
                    responseInfo.StatusText = "Not Found";
                    return false;
                }

                int index = resString.IndexOf("base64,", StringComparison.Ordinal);
                string mime = resString.Substring(5, index - 5);

                string contentBase64 = resString.Substring(index + 7);

                byte[] contentBase64Bytes = Convert.FromBase64String(contentBase64);


                responseInfo = new ResponseInfo(contentBase64Bytes);
                string utf8Extension = GetUtf8IfNeeded(mime);
                responseInfo.Header.Add("content-type", mime + utf8Extension);
                //responseInfo.Header.Add("origin", "diga://"+ uri.Host);
                //responseInfo.Header.Add("Set-Cookie", "sessionId=38afes7a8");
                responseInfo.ContentType = mime;
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