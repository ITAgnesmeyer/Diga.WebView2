using System;

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
}