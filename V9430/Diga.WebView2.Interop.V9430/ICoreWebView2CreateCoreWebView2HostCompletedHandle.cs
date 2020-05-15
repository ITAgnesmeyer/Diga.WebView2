// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2CreateCoreWebView2HostCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("E09F5D38-91E3-49D1-8182-70A616AA06B9")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CreateCoreWebView2HostCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int result, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Host created_host);
  }
}
