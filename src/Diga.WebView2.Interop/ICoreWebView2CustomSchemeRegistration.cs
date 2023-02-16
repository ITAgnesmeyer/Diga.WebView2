// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CustomSchemeRegistration
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2BA7B24E-98CF-4C8D-98F5-352A5D059C6B
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1587.40\Diga.WebView2.Interop.dll

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("D60AC92C-37A6-4B26-A39E-95CFE59047BB")]
  [ComConversionLoss]
  [ComImport]
  public interface ICoreWebView2CustomSchemeRegistration
  {
    [DispId(1610678272)]
    string SchemeName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    int TreatAsSecure { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetAllowedOrigins(out uint allowedOriginsCount, [Out] IntPtr allowedOrigins);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void SetAllowedOrigins([In] uint allowedOriginsCount, [MarshalAs(UnmanagedType.LPWStr), In] ref string allowedOrigins);

    [DispId(1610678277)]
    int HasAuthorityComponent { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
