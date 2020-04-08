using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    internal static class Native
    {
        public const string ExternalDll = "WebView2Loader.dll";

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out tagRECT lpRect);
        
        [DllImport(ExternalDll, SetLastError = true)]
        public static extern int CreateCoreWebView2EnvironmentWithDetails(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string userDataFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string additionalBrowserArguments,
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

       
        [DllImport(ExternalDll, SetLastError = true)]
        public static extern int CreateCoreWebView2Environment(
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        
        [DllImport(ExternalDll, SetLastError = true)]
        public static extern int GetCoreWebView2BrowserVersionInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);
    }
}