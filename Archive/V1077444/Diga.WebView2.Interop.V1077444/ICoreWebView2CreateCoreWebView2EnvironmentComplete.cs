// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("4E8A3389-C9D8-4BD2-B6B5-124FEE6CC14D")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int errorCode, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment createdEnvironment);
  }
}
