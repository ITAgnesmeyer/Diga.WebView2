using System;

namespace Diga.WebView2.Wrapper.Types
{
    internal static  class ProcessorArch
    {
        public static bool Is64BitProcess
        {
            get { return IntPtr.Size == 8; }
        }
    }
}