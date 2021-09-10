// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ZoomFactorChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0C0240C-E7D7-45C8-B13A-ACBB49432772
// Assembly location: O:\webview2\V9622\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("B52D71D6-C4DF-4543-A90C-64A3E60F38CB")]
  [ComImport]
  public interface ICoreWebView2ZoomFactorChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Controller sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
