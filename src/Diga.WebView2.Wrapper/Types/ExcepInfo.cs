using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Represents the EXCEPINFO structure used in COM interop to provide detailed error information.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public class ExcepInfo
    {
        /// <summary>
        /// Reserved pointer, must be set to IntPtr.Zero.
        /// </summary>
        public IntPtr pvReserved = IntPtr.Zero;
        /// <summary>
        /// Pointer to a deferred fill-in function, must be set to IntPtr.Zero.
        /// </summary>
        public IntPtr pfnDeferredFillIn = IntPtr.Zero;
        /// <summary>
        /// Error code.
        /// </summary>
        [MarshalAs(UnmanagedType.U2)]
        public short wCode;
        /// <summary>
        /// Reserved field.
        /// </summary>
        [MarshalAs(UnmanagedType.U2)]
        public short wReserved;
        /// <summary>
        /// Source of the exception.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrSource;
        /// <summary>
        /// Description of the exception.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrDescription;
        /// <summary>
        /// Help file associated with the exception.
        /// </summary>
        [MarshalAs(UnmanagedType.BStr)]
        public string bstrHelpFile;
        /// <summary>
        /// Help context ID.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int dwHelpContext;
        /// <summary>
        /// Status code.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int scode;
    }
}