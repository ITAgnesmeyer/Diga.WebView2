﻿// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2AcceleratorKeyPressedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("B29C7E28-FA79-41A8-8E44-65811C76DCB2")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2AcceleratorKeyPressedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Controller sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AcceleratorKeyPressedEventArgs args);
  }
}
