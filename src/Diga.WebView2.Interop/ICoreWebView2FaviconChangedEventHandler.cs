// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FaviconChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED88F383-EEB9-472A-9573-53250CD6B18B
// Assembly location: O:\webview2\Microsoft.Web.WebView2.1.0.1370.28\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("2913DA94-833D-4DE0-8DCA-900FC524A1A4")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2FaviconChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
