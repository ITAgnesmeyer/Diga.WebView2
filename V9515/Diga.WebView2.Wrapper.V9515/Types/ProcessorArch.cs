using System;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper.Types
{
    internal static  class ProcessorArch
    {
        public static bool Is64BitProcess => IntPtr.Size == 8;
    }
}