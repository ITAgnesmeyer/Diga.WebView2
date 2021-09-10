using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public sealed class DispParams
    {
        public IntPtr rgvarg;
        public IntPtr rgdispidNamedArgs;
        [MarshalAs(UnmanagedType.U4)]
        public int cArgs;
        [MarshalAs(UnmanagedType.U4)]
        public int cNamedArgs;
    }
}