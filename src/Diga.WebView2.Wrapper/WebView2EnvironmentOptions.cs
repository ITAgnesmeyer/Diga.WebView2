using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.interop;
using Diga.WebView2.Wrapper.Types;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using IntPtr = System.IntPtr;

namespace Diga.WebView2.Wrapper
{
    public class WebView2EnvironmentOptions : ICoreWebView2EnvironmentOptions4
    {
        public WebView2EnvironmentOptions()
        {
            Native.GetCurrentVersion(out string version);
            this.TargetCompatibleBrowserVersion = version;
            this.AllowSingleSignOnUsingOSPrimaryAccount = new CBOOL(true);
            this.ExclusiveUserDataFolderAccess = new CBOOL(false);
            this.IsCustomCrashReportingEnabled = new CBOOL(false);
            this.CustomSchemeRegistrations = new List<WebView2CustomSchemeRegistration>();
        }
        public string AdditionalBrowserArguments { get; set; }
        public string Language { get; set; }
        public string TargetCompatibleBrowserVersion { get; set; }
        public int AllowSingleSignOnUsingOSPrimaryAccount { get; set; }
        public int ExclusiveUserDataFolderAccess { get; set; }
        public int IsCustomCrashReportingEnabled { get; set; }
        public List<WebView2CustomSchemeRegistration> CustomSchemeRegistrations { get; }
        public void GetCustomSchemeRegistrations(out uint Count, [Out] IntPtr schemeRegistrations)
        {
            if (this.CustomSchemeRegistrations.Count == 0)
            {
                Count = 0U;
            }
            else
            {
                Count = (uint)this.CustomSchemeRegistrations.Count;
                int size = Marshal.SizeOf<IntPtr>();
                IntPtr val = Marshal.AllocCoTaskMem((int)Count * size);
                for (int index = 0; index < Count; index++)
                {
                    object obj = this.CustomSchemeRegistrations[index];
                    #pragma warning disable CA1416
                    Marshal.WriteIntPtr(val + index * size, Marshal.GetComInterfaceForObject(obj, typeof(ICoreWebView2CustomSchemeRegistration)));
                    #pragma warning restore CA1416
                }
                Marshal.WriteIntPtr(schemeRegistrations,val);
            }
        }

        public void SetCustomSchemeRegistrations([In] uint Count, [In, MarshalAs(UnmanagedType.Interface)] ref ICoreWebView2CustomSchemeRegistration schemeRegistrations)
        {
            throw new NotImplementedException();
        }
    }
}