using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper
{

    internal static class Native
    {
        private static bool _is64Bit;

        static Native()
        {
            _is64Bit = ProcessorArch.Is64BitProcess;
        }

        public static bool GetClientRect(IntPtr hWnd, out tagRECT lpRect)
        {
            return _is64Bit
                ? Native64.GetClientRect(hWnd, out lpRect)
                : Native32.GetClientRect(hWnd, out lpRect);
        }

#if VS8355
        public static int CreateWebView2EnvironmentWithDetails(
            string browserExecutableFolder,
            string userDataFolder,
            string additionalBrowserArguments,
            IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
                ? Native64.CreateWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler)
                : Native32.CreateWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler);
        }
        public static int CreateCoreWebView2Environment(
          IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
                ? Native64.CreateCoreWebView2Environment(environmentCreatedHandler)
                : Native32.CreateCoreWebView2Environment(environmentCreatedHandler);
        }

        public static int GetWebView2BrowserVersionInfo(
            string browserExecutableFolder,
            out string versionInfo)
        {
            return _is64Bit
                ? Native64.GetWebView2BrowserVersionInfo(browserExecutableFolder, out versionInfo)
                : Native32.GetWebView2BrowserVersionInfo(browserExecutableFolder, out versionInfo);
        }
#endif
#if V9430
        public static int CreateCoreWebView2EnvironmentWithDetails(
            string browserExecutableFolder,
            string userDataFolder,
            string additionalBrowserArguments,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
                ? Native64.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler)
                : Native32.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler);
        }

        public static int CreateCoreWebView2Environment(
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
                ? Native64.CreateCoreWebView2Environment(environmentCreatedHandler)
                : Native32.CreateCoreWebView2Environment(environmentCreatedHandler);
        }


        public static int GetCoreWebView2BrowserVersionInfo(
            string browserExecutableFolder,
            out string versionInfo)
        {
            return _is64Bit
                ? Native64.GetCoreWebView2BrowserVersionInfo(browserExecutableFolder, out versionInfo)
                : Native32.GetCoreWebView2BrowserVersionInfo(browserExecutableFolder, out versionInfo);
        }
#endif
#if V9488
        public static int CreateCoreWebView2EnvironmentWithOptions(string browserExecutableFolder,
            string userDataFolder, ICoreWebView2EnvironmentOptions environmentOptions,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
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
            return _is64Bit
                ? Native64.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler)
                : Native32.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                    additionalBrowserArguments, environmentCreatedHandler);
        }

        public static int CreateCoreWebView2Environment(
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            return _is64Bit
                ? Native64.CreateCoreWebView2Environment(environmentCreatedHandler)
                : Native32.CreateCoreWebView2Environment(environmentCreatedHandler);
        }


        public static int GetCoreWebView2BrowserVersionInfo(
            string browserExecutableFolder,
            out string versionInfo)
        {
            return _is64Bit
                ? Native64.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, out versionInfo)
                : Native32.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, out versionInfo);
        }
#endif


    }

    internal static class Native32
    {
        private const string EXTERNAL_DLL = "native/x86/WebView2Loader.dll";
        //private const string EXTERNAL_DLL = "WebView2Loader.dll";

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out tagRECT lpRect);

#if VS8355
        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CreateWebView2EnvironmentWithDetails([In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string userDataFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string additionalBrowserArguments,
            [In] IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler);
        [DllImport(EXTERNAL_DLL, SetLastError = true)]

        public static extern int CreateCoreWebView2Environment(
           [In] IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int GetWebView2BrowserVersionInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);
#endif
#if V9430
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
        public static extern int GetCoreWebView2BrowserVersionInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);

#endif
#if V9488
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
#endif

    }


    internal static class Native64
    {
        private const string EXTERNAL_DLL = "native/x64/WebView2Loader.dll";
        //private const string EXTERNAL_DLL = "WebView2Loader.dll";

        [DllImport("user32.dll")]
        internal static extern bool GetClientRect(IntPtr hWnd, out tagRECT lpRect);

#if VS8355
        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int CreateWebView2EnvironmentWithDetails([In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string userDataFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string additionalBrowserArguments,
            [In] IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler);
        [DllImport(EXTERNAL_DLL, SetLastError = true)]

        public static extern int CreateCoreWebView2Environment(
           [In] IWebView2CreateWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        [DllImport(EXTERNAL_DLL, SetLastError = true)]
        public static extern int GetWebView2BrowserVersionInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);
#endif 
#if V9430
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
        public static extern int GetCoreWebView2BrowserVersionInfo(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);

#endif
#if V9488
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
#endif

    }
}