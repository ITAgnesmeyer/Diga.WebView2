using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public class ExcepInfo
    {
        public IntPtr pvReserved = IntPtr.Zero;
        public IntPtr pfnDeferredFillIn = IntPtr.Zero;
        [MarshalAs(UnmanagedType.U2)]
        public short wCode;
        [MarshalAs(UnmanagedType.U2)]
        public short wReserved;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrSource;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrDescription;
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrHelpFile;
        [MarshalAs(UnmanagedType.U4)]
        public int dwHelpContext;
        [MarshalAs(UnmanagedType.U4)]
        public int scode;
    }
}