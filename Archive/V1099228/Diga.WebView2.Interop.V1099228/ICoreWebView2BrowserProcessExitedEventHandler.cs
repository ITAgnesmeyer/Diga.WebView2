// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2BrowserProcessExitedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78A35386-8488-46E1-BA73-85C815D94A35
// Assembly location: O:\webview2\V1099228\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("FA504257-A216-4911-A860-FE8825712861")]
  [ComImport]
  public interface ICoreWebView2BrowserProcessExitedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Environment sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BrowserProcessExitedEventArgs args);
  }
}
