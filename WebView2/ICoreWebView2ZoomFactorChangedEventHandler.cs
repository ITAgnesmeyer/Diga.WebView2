﻿// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2ZoomFactorChangedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 390039CF-BF77-421E-8AE4-CC8FD0DF2A08
// Assembly location: O:\dev\webview2-interop-master\Src\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("1B03A40F-92B7-443A-87E0-B65714B6CB9D")]
  [ComImport]
  public interface ICoreWebView2ZoomFactorChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Host sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
