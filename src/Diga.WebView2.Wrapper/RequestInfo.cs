using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Diga.WebView2.Wrapper
{
    public class RequestInfo
    {
        public string Uri { get; }
        public string Method { get; }
        public string Content { get; private set; }

        public Dictionary<string, string> Headers { get; }

        public RequestInfo(WebResourceRequest resquest)
        {
            this.Headers = new Dictionary<string, string>();
            this.Uri = resquest.Uri;
            this.Method = resquest.Method;
            this.Content = string.Empty;
            ReadContent(resquest.Content);

            CopyHeaer(resquest.Headers);

        }

        private void ReadContent(Stream contentStream)
        {
            if (contentStream == null) return;
            try
            {
                using (StreamReader sr = new StreamReader(contentStream, Encoding.UTF8))
                {
                    this.Content = sr.ReadToEnd();
                }

            }
            catch (Exception e)
            {
                Debug.Print("ReadContent exception:" + e.Message);
            }
        }
        private void CopyHeaer(HttpRequestHeaders headers)
        {
            if (headers == null)
                return;
            var iterator = headers.GetIterator();
            if (iterator == null) return;
            if (iterator.HasCurrent)
            {
                string key = iterator.Current.Name;
                string value = iterator.Current.Value;
                this.Headers.Add(key, value);
            }

            while (iterator.MoveNext())
            {
                string key = iterator.Current.Name;
                string value = iterator.Current.Value;
                this.Headers.Add(key, value);
            }
        }

    }
}