using System;
using System.Collections.Generic;

namespace Diga.WebView2.Monitoring.CGI
{
    public class CgiResponse
    {
        public Dictionary<string, string> Headers { get; }
        public string Body { get; set; }

        public CgiResponse()
        {
            this.Headers = new Dictionary<string, string>();
        }

        public CgiResponse(string value) : this()
        {
            Fill(value);
        }

        private void Fill(string value)
        {
            string[] arr = {"\r\n" };
            string[] lines = value.Split(arr,StringSplitOptions.None);
            bool headerEnd = false;
            foreach (string line in lines)
            {
                if (!headerEnd)
                {
                    if (string.IsNullOrEmpty(line))
                    {
                        headerEnd = true;
                        continue;
                    }

                    int index = line.IndexOf(':');
                    if (index != -1)
                    {
                        string k = line.Substring(0, index);
                        string v = string.Empty;
                        if (line.Length > index + 2) v = line.Substring(index + 2);
                        this.Headers.Add(k, v);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(this.Body)) this.Body += "\r\n";
                    this.Body += line;
                }
            }
        }
    }
}