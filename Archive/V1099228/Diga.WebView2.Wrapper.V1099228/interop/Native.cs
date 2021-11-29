using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.interop
{

    internal static class Native
    {
        private static readonly Architecture OsArchitecture;

        static Native()
        {
            OsArchitecture = ProcessorArch.GetArchitecture();

        }

        public static bool GetClientRect(IntPtr hWnd, out tagRECT lpRect)
        {
            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.GetClientRect(hWnd, out lpRect);
                case Architecture.X86:
                    return Native64.GetClientRect(hWnd, out lpRect);
                case Architecture.Arm64:
                    return NativeArm64.GetClientRect(hWnd, out lpRect);
                default:
                    throw new PlatformNotSupportedException();
            }

        }


        public static int CreateCoreWebView2EnvironmentWithOptions(string browserExecutableFolder,
            string userDataFolder, ICoreWebView2EnvironmentOptions environmentOptions,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                case Architecture.X86:
                    return Native32.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                case Architecture.Arm64:
                    return NativeArm64.CreateCoreWebView2EnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                default:
                    throw new PlatformNotSupportedException();

            }

        }
        public static int CreateCoreWebView2EnvironmentWithDetails(
            string browserExecutableFolder,
            string userDataFolder,
            string additionalBrowserArguments,
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {

            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                        additionalBrowserArguments, environmentCreatedHandler);
                case Architecture.X86:
                    return Native32.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                        additionalBrowserArguments, environmentCreatedHandler);
                case Architecture.Arm64:
                    return NativeArm64.CreateCoreWebView2EnvironmentWithDetails(browserExecutableFolder, userDataFolder,
                        additionalBrowserArguments, environmentCreatedHandler);
                default:
                    throw new PlatformNotSupportedException();
            }


        }

        public static int CreateCoreWebView2Environment(
            ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {

            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.CreateCoreWebView2Environment(environmentCreatedHandler);
                case Architecture.X86:
                    return Native32.CreateCoreWebView2Environment(environmentCreatedHandler);
                case Architecture.Arm64:
                    return NativeArm64.CreateCoreWebView2Environment(environmentCreatedHandler);
                default:
                    throw new PlatformNotSupportedException();
            }
        }


        public static int GetAvailableCoreWebView2BrowserVersionString(
            string browserExecutableFolder,
            out string versionInfo)
        {

            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder,
                        out versionInfo);
                case Architecture.X86:
                    return Native32.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder, out versionInfo);
                case Architecture.Arm64:
                    return NativeArm64.GetAvailableCoreWebView2BrowserVersionString(browserExecutableFolder,
                        out versionInfo);
                default:
                    throw new PlatformNotSupportedException();
            }

        }



    }
}