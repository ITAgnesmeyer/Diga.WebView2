using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{

    internal static class Native
    {
        private static readonly bool Is64Bit;

        static Native()
        {
            Is64Bit = ProcessorArch.Is64BitProcess;
        }

        public static bool GetClientRect(IntPtr hWnd, out tagRECT lpRect)
        {
            return Is64Bit
                ? Native64.GetClientRect(hWnd, out lpRect)
                : Native32.GetClientRect(hWnd, out lpRect);
        }


        public static int CreateCoreWebView2EnvironmentWithOptions(string browserExecutableFolder,
            string userDataFolder, ICoreWebView2EnvironmentOptions environmentOptions,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return Is64Bit
                ? Native64.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                    environmentOptions, environmentCreatedHandler)
                : Native32.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                    environmentOptions, environmentCreatedHandler);
        }
        public static int CreateCoreWebView2EnvironmentWithDetails(
            string browserExecutableFolder,
            string userDataFolder,
            string additionalBrowserArguments,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return Is64Bit
                ? Native64.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler)
                : Native32.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler);
        }

        public static int CreateCoreWebView2Environment(
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return Is64Bit
                ? Native64.CreateCoreWebView2Environment(environmentCreatedHandler)
                : Native32.CreateCoreWebView2Environment(environmentCreatedHandler);
        }


        public static int GetAvailableCoreWebView2BrowserVersionString(
            string browserExecutableFolder,
            out string versionInfo)
        {
            return Is64Bit
                ? Native64.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, out versionInfo)
                : Native32.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, out versionInfo);
        }



    }

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


    internal static class Native64
    {
        private const string EXTERNAL_DLL = "native/x64/WebView2Loader.dll";
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