// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2BrowserProcessExitedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78A35386-8488-46E1-BA73-85C815D94A35
// Assembly location: O:\webview2\V1099228\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("1F00663F-AF8C-4782-9CDD-DD01C52E34CB")]
  [ComImport]
  public interface ICoreWebView2BrowserProcessExitedEventArgs
  {
    [DispId(1610678272)]
    COREWEBVIEW2_BROWSER_PROCESS_EXIT_KIND BrowserProcessExitKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    uint BrowserProcessId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
