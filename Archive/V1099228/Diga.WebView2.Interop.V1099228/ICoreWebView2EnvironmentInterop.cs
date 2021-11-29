// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2EnvironmentInterop
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("EE503A63-C1E2-4FBF-8A4D-824E95F8BB13")]
  [ComImport]
  public interface ICoreWebView2EnvironmentInterop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    object GetProviderForHwnd(IntPtr hwnd);
  }
}
