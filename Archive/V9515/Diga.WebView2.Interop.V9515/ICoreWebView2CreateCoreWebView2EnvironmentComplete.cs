// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("8B4F98CE-DB0D-4E71-85FD-C4C4EF1F2630")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CreateCoreWebView2EnvironmentCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int result, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Environment created_environment);
  }
}
