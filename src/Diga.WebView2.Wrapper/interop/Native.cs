using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Diga.WebView2.Interop;
using Diga.WebView2.Wrapper.Types;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.interop
{

    internal static class Native
    {
        [StructLayout(LayoutKind.Sequential,CharSet =CharSet.Auto)]
        public struct MSG
        {
            public IntPtr hwnd;
            public uint message;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public tagPOINT pt;
        }
        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        ///wRemoveMsg: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint="PeekMessageW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern  bool PeekMessage(ref MSG lpMsg, IntPtr hWnd , uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg) ;


        [DllImport("user32.dll", EntryPoint = "TranslateMessage")]
        private static extern bool TranslateMessage([In] ref MSG lpMsg);

        [DllImport("user32.dll", EntryPoint = "DispatchMessage", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr DispatchMessage([In] ref MSG lpmsg);
        //[DllImport("user32.dll", EntryPoint = "GetMessage", CharSet = CharSet.Auto)]
        //public static extern sbyte GetMessage(ref MSG lpMsg, IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax);

        /// Return Type: BOOL->int
        ///lpMsg: LPMSG->tagMSG*
        ///hWnd: HWND->HWND__*
        ///wMsgFilterMin: UINT->unsigned int
        ///wMsgFilterMax: UINT->unsigned int
        [DllImport("user32.dll", EntryPoint="GetMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern  bool GetMessage(ref MSG lpMsg, [In()] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax) ;


        /// Return Type: BOOL->int
        [DllImport("user32.dll", EntryPoint="WaitMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool WaitMessage() ;

        public static void DoEvents()
        {
            var msg = new MSG();
            bool continueLoop = true;
            while (continueLoop)
            {
                if (PeekMessage(ref msg, IntPtr.Zero, 0, 0, 0x0000))
                {
                    if (!GetMessage(ref msg, IntPtr.Zero, 0, 0))
                    {
                        continue;
                    }

                    TranslateMessage(ref msg);
                    DispatchMessage(ref msg);
                }
                else
                {
                    break;
                }


            }

        }

        public static T AsyncCall<T>(Task<T> tsk)
        {
            TaskAwaiter<T> awaiter = tsk.GetAwaiter();
            while (!awaiter.IsCompleted)
            {
                Thread.Sleep(10);
                DoEvents();
            }
            return awaiter.GetResult();
        }


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