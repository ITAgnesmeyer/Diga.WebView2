﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FrameCreatedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92B97282-7222-4AB4-B087-3F0FC910320A
// Assembly location: O:\webview2\v1090249\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("38059770-9BAA-11EB-A8B3-0242AC130003")]
  [ComImport]
  public interface ICoreWebView2FrameCreatedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameCreatedEventArgs args);
  }
}
