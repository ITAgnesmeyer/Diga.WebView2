﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2WindowCloseRequestedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("5C19E9E0-092F-486B-AFFA-CA8231913039")]
  [ComImport]
  public interface ICoreWebView2WindowCloseRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
