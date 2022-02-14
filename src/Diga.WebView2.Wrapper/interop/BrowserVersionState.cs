using System;

namespace Diga.WebView2.Wrapper.interop
{
    [Flags]        
    internal enum BrowserVersionState:int
    {
        Older = -1,
        Equal = 0,
        Newer = 1
    }
}