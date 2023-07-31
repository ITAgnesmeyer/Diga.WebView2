using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

namespace Diga.WebView2.Wrapper
{
    public class SchemeRegistration
    {
        public string SchemeName { get; set; }
        public bool TreatAsSecure { get; set; }
        public string[] AllowedOrignis { get; set; } = { };


        internal WebView2CustomSchemeRegistration GetAsWebView2CustomSchemeRegistration()
        {
            var newValue = new WebView2CustomSchemeRegistration(this.SchemeName);
            newValue.AllowedOrgins.AddRange(this.AllowedOrignis);
            newValue.TreatAsSecure = (CBOOL)this.TreatAsSecure;
            return newValue;
        }
    }
    public class WebView2CustomSchemeRegistration : ICoreWebView2CustomSchemeRegistration
    {
        public WebView2CustomSchemeRegistration(string schemaName)
        {
            this.SchemeName = schemaName;
            this.TreatAsSecure = (CBOOL)false;
            this.HasAuthorityComponent = (CBOOL)false;
            this.AllowedOrgins = new List<string>();
            this.HasAuthorityComponent = (CBOOL)false;
        }
        public string SchemeName { get;}
        public int TreatAsSecure { get; set; }
        public List<string> AllowedOrgins { get; }

        public void GetAllowedOrigins(out uint allowedOriginsCount, IntPtr allowedOrigins)
        {
            allowedOriginsCount = (uint)this.AllowedOrgins.Count;
            if (allowedOriginsCount == 0)
            {
                return;
            }

            IntPtr val = Marshal.AllocCoTaskMem((int)allowedOriginsCount * Marshal.SizeOf<IntPtr>());
            for (int i = 0; i < allowedOriginsCount; i++)
            {
                Marshal.WriteIntPtr(val + i * Marshal.SizeOf<IntPtr>(),Marshal.StringToCoTaskMemAuto(this.AllowedOrgins[i]));
            }
            Marshal.WriteIntPtr(allowedOrigins, val);

        }

        public void SetAllowedOrigins(uint allowedOriginsCount, ref string allowedOrigins)
        {
            throw new NotImplementedException();
        }

        public int HasAuthorityComponent { get; set; }
    }
}