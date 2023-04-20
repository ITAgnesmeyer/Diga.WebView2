// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Profile
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7E16C74E-5A5B-41DB-9F54-62C7717B4DB7
// Assembly location: O:\webview2\V10121039\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{

    [Guid("1656D586-E714-4092-9C76-014647940EFF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ICoreWebView2PrivateHostObjectHelper
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        int IsMethodMember([ In] ref object @object, [MarshalAs(UnmanagedType.LPWStr), In] string memberName);
    }
}
