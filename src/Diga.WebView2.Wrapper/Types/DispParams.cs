using System;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Wrapper.Types
{
    /// <summary>
    /// Represents the DISPPARAMS structure used in COM interop for method invocation arguments.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class DispParams
    {
        /// <summary>
        /// Pointer to an array of arguments.
        /// </summary>
        public IntPtr rgvarg;
        /// <summary>
        /// Pointer to an array of named argument DISPIDs.
        /// </summary>
        public IntPtr rgdispidNamedArgs;
        /// <summary>
        /// The count of arguments.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int cArgs;
        /// <summary>
        /// The count of named arguments.
        /// </summary>
        [MarshalAs(UnmanagedType.U4)]
        public int cNamedArgs;
    }
}