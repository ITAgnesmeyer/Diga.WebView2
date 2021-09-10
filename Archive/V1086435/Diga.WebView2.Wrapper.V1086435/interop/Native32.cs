using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{
    internal static class Native32
    {
        private const string EXTERNAL_DLL = "native/x86/WebView2Loader.dll";
        //private const string EXTERNAL_DLL = "WebView2Loader.dll";

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out tagRECT lpRect);




        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CreateCoreWebView2EnvironmentWithOptions(
            [In, MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)] string userDataFolder,
            [In] ICoreWebView2EnvironmentOptions environmentOptions,
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);


        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CreateCoreWebView2EnvironmentWithDetails(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string userDataFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string additionalBrowserArguments,
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CreateCoreWebView2Environment(
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int GetAvailableCoreWebView2BrowserVersionString(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);

        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CompareBrowserVersions(
            [In, MarshalAs(UnmanagedType.LPWStr)] string version1,
            [In, MarshalAs(UnmanagedType.LPWStr)] string version2,
            out int result);


    }
}