﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DownloadStartingEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92B97282-7222-4AB4-B087-3F0FC910320A
// Assembly location: O:\webview2\v1090249\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("EFEDC989-C396-41CA-83F7-07F845A55724")]
  [ComImport]
  public interface ICoreWebView2DownloadStartingEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DownloadStartingEventArgs args);
  }
}
