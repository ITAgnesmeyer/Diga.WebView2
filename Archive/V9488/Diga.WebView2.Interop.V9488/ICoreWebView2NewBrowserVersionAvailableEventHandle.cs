// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2NewBrowserVersionAvailableEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B5F140DB-135D-4E8A-B1A2-1275CE2FD56A
// Assembly location: O:\webview2\webview2packages\V9488\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("E82E8242-EE39-4A57-A065-E13256D60342")]
  [ComImport]
  public interface ICoreWebView2NewBrowserVersionAvailableEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Environment webviewEnvironment, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
