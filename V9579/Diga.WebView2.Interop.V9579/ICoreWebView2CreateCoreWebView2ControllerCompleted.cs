// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("86EF6808-3C3F-4C6F-975E-8CE0B98F70BA")]
  [ComImport]
  public interface ICoreWebView2CreateCoreWebView2ControllerCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error)] int result, [MarshalAs(UnmanagedType.Interface)] ICoreWebView2Controller createdController);
  }
}
