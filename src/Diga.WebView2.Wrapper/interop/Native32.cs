﻿using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.interop
{

    internal static class Native32
    {
        private const string EXTERNAL_DLL = "native/x86/Diga.WebView2.Native.dll";


        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall)]
        public static extern int ShowInfo();
        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int CompareVersion(
            [In, MarshalAs(UnmanagedType.LPWStr)] string version1,
            [In, MarshalAs(UnmanagedType.LPWStr)] string version2,
            out int result);

        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetAvailableVersion(
            [In, MarshalAs(UnmanagedType.LPWStr)]
            string browserExecutableFolder,
            [MarshalAs(UnmanagedType.LPWStr)]
            out string versionInfo);

        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int CreateEnvironment(
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);

        [DllImport(EXTERNAL_DLL,EntryPoint = "CreateEnvironment", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern int CreateEnvironmentX(IntPtr envecreateHandler);

        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int CreateEnvironmentWithOptions(
            [In, MarshalAs(UnmanagedType.LPWStr)] string browserExecutableFolder,
            [In, MarshalAs(UnmanagedType.LPWStr)] string userDataFolder,
            [In] ICoreWebView2EnvironmentOptions environmentOptions,
            [In] ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler environmentCreatedHandler);


        [DllImport(EXTERNAL_DLL, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern int GetCurrentVersion([MarshalAs(UnmanagedType.LPWStr)] out string versionInfo);


    }
}