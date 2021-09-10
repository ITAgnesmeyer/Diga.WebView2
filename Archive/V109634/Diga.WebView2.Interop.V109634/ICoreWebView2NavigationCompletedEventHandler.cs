// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NavigationCompletedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0C0240C-E7D7-45C8-B13A-ACBB49432772
// Assembly location: O:\webview2\V9622\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("D33A35BF-1C49-4F98-93AB-006E0533FE1C")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2NavigationCompletedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NavigationCompletedEventArgs args);
  }
}
