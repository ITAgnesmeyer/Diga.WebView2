﻿// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2WebResourceRequestedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("E2AE08C1-4F67-4348-AE05-C89CB14C2ADD")]
  [ComImport]
  public interface IWebView2WebResourceRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2WebView webview, [MarshalAs(UnmanagedType.Interface), In] IWebView2WebResourceRequestedEventArgs2 args);
  }
}
