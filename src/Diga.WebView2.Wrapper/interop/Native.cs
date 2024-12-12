using System;
using System.Runtime.InteropServices;
using System.Threading;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.interop
{
   

    public static class Native
    {




        private static readonly Architecture OsArchitecture;

        static Native()
        {
            Thread.CurrentThread.TrySetApartmentState(ApartmentState.STA);
            OsArchitecture = ProcessorArch.GetArchitecture();

        }



        public static int ShowInfo()
        {
            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.ShowInfo();
                case Architecture.X86:
                    return Native64.ShowInfo();
                case Architecture.Arm64:
                    return NativeArm64.ShowInfo();
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
                    return Native64.CreateEnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                case Architecture.X86:
                    return Native32.CreateEnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                case Architecture.Arm64:
                    return NativeArm64.CreateEnvironmentWithOptions(browserExecutableFolder, userDataFolder,
                        environmentOptions, environmentCreatedHandler);
                default:
                    throw new PlatformNotSupportedException();

            }

        }

        public static int CreateCoreWebView2EvenironmentX(ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler)
        {
            object o = environmentCreatedHandler;
            GCHandle h = GCHandle.Alloc(o);
            IntPtr p = h.AddrOfPinnedObject();

            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.CreateEnvironmentX(p);
                case Architecture.X86:
                    return Native32.CreateEnvironmentX(p);
                case Architecture.Arm64:
                    return NativeArm64.CreateEnvironment(environmentCreatedHandler);
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
                    return Native64.CreateEnvironment(environmentCreatedHandler);
                case Architecture.X86:
                    return Native32.CreateEnvironment(environmentCreatedHandler);
                case Architecture.Arm64:
                    return NativeArm64.CreateEnvironment(environmentCreatedHandler);
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
                    return Native64.GetAvailableVersion(browserExecutableFolder,
                        out versionInfo);
                case Architecture.X86:
                    return Native32.GetAvailableVersion(browserExecutableFolder, out versionInfo);
                case Architecture.Arm64:
                    return NativeArm64.GetAvailableVersion(browserExecutableFolder,
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
                    return Native64.CompareVersion(version1, version1, out result);

                case Architecture.X86:
                    return Native32.CompareVersion(version1, version2, out result);

                case Architecture.Arm64:
                    return NativeArm64.CompareVersion(version1, version1, out result);

                default:
                    throw new PlatformNotSupportedException();
            }
        }

        public static int GetCurrentVersion(out string versionInfo)
        {

            switch (OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.GetCurrentVersion(out versionInfo);
                case Architecture.X86:
                    return Native32.GetCurrentVersion(out versionInfo);
                case Architecture.Arm64:
                    return NativeArm64.GetCurrentVersion(out versionInfo); 
                default:
                    throw new NotSupportedException("Architecture not supported");
            }
        }

        public static int GetIUnknownPointerFromObject(ref object comObject, out IntPtr pUnknown)
        {
            switch(OsArchitecture)
            {
                case Architecture.X64:
                    return Native64.GetIUnknownPointerFromObject(ref comObject, out pUnknown);
                case Architecture.X86:
                    return Native32.GetIUnknownPointerFromObject(ref comObject, out pUnknown);
                case Architecture.Arm64:
                    return NativeArm64.GetIUnknownPointerFromObject(ref comObject, out pUnknown);
                default:
                    throw new PlatformNotSupportedException();
            }
        }

    }
}