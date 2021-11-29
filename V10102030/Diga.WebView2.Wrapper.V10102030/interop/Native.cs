using System;
using System.Runtime.InteropServices;
using System.Threading;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.interop
{

    internal static class Native
    {
        [Flags]        
        public enum BrowserVersionState:int
        {
            Older = -1,
            Equal = 0,
            Newer = 1
        }

        [Flags]
        private enum CoInit :uint
        {
    
            /// COINIT_APARTMENTTHREADED -> 0x2
            ApartmentThreaded = 2,
    
            /// COINIT_MULTITHREADED -> 0x0
            MultiThreaded = 0,
    
            /// COINIT_DISABLE_OLE1DDE -> 0x4
            DisableOle1Dde = 4,
    
            /// COINIT_SPEED_OVER_MEMORY -> 0x8
            SpeedOverMemory = 8,
        }


        private const int E_INVALIDARG = unchecked((int)0x80070057);
        
        [DllImport("ole32.dll", EntryPoint="CoInitializeEx", CallingConvention=CallingConvention.StdCall)]
        private static extern  int CoInitializeEx([In]IntPtr pvReserved,[In] CoInit dwCoInit) ;

        [DllImport("ole32.dll", EntryPoint="CoUninitialize", CallingConvention=CallingConvention.StdCall)]
        private static extern  void CoUninitialize() ;



        private static readonly Architecture OsArchitecture;

        static Native()
        {
            Thread.CurrentThread.TrySetApartmentState(ApartmentState.STA);
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

        [Obsolete]
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

        public static int CompareBrowserVersions(string version1, string version2, out int result)
        {
            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.CompareBrowserVersions(version1, version1, out result);
                    
                case Architecture.X86:
                    return Native32.CompareBrowserVersions(version1, version2, out result);
                    
                case Architecture.Arm64:
                    return NativeArm64.CompareBrowserVersions(version1, version1, out result);
                    
                default:
                    throw new PlatformNotSupportedException();
            }
        }
        


    }
}