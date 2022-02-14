using System;
using System.Runtime.InteropServices;
using Diga.WebView2.Interop;

namespace Diga.WebView2.Wrapper.interop
{
    internal static class NativeUser32
    {
        private const string USER32 = "user32.dll";
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
     
        [DllImport(USER32, EntryPoint="PeekMessage",CharSet = CharSet.Auto,SetLastError = true )]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekMessage([Out] out MSG lpMsg, [In] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax, uint wRemoveMsg);


        [DllImport(USER32, EntryPoint = "TranslateMessage")]
        public static extern bool TranslateMessage([In] ref MSG lpMsg);

       
        [DllImport(USER32, EntryPoint = "DispatchMessage", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr DispatchMessage([In] ref MSG lpmsg);

      
        [DllImport(USER32, EntryPoint="GetMessage")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern  bool GetMessage(ref MSG lpMsg, [In()] IntPtr hWnd, uint wMsgFilterMin, uint wMsgFilterMax) ;
        
        [DllImport(USER32, EntryPoint = "GetClientRect")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetClientRect([In] IntPtr hWnd, [Out] out tagRECT lpRect);
    }
}