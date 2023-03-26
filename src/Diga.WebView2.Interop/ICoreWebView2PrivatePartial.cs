// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Profile
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7E16C74E-5A5B-41DB-9F54-62C7717B4DB7
// Assembly location: O:\webview2\V10121039\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
    [Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [ComImport]
    public interface ICoreWebView2PrivatePartial
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        void AddHostObjectHelper([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2PrivateHostObjectHelper helper);
    }
}
