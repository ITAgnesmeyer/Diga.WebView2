﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ProcessFailedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0C0240C-E7D7-45C8-B13A-ACBB49432772
// Assembly location: O:\webview2\V9622\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("8155A9A4-1474-4A86-8CAE-151B0FA6B8CA")]
  [ComImport]
  public interface ICoreWebView2ProcessFailedEventArgs
  {
    [DispId(1610678272)]
    COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
