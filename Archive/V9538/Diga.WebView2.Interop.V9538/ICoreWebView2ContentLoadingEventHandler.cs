// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2ContentLoadingEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("7AF5CC82-AE19-4964-BD71-B9BC5F03E85D")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContentLoadingEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 webview, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContentLoadingEventArgs args);
  }
}
