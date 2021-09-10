// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2HttpHeadersCollectionIterator
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0C0240C-E7D7-45C8-B13A-ACBB49432772
// Assembly location: O:\webview2\V9622\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("0702FC30-F43B-47BB-AB52-A42CB552AD9F")]
  [ComImport]
  public interface ICoreWebView2HttpHeadersCollectionIterator
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetCurrentHeader([MarshalAs(UnmanagedType.LPWStr)] out string name, [MarshalAs(UnmanagedType.LPWStr)] out string value);

    [DispId(1610678273)]
    int HasCurrentHeader { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    int MoveNext();
  }
}
