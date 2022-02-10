using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    [Guid("DF362C62-3B8E-484A-8DE0-FE2CB31EDBC5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICoreWebView2StagingHostObjectHelper
    {
        int IsMethodMember(ref object rawObject, [MarshalAs(UnmanagedType.LPWStr), In] string memberName);
    }
}