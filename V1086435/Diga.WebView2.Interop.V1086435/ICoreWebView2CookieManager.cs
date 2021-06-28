// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CookieManager
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("177CD9E7-B6F5-451A-94A0-5D7A3A4C4141")]
  [ComImport]
  public interface ICoreWebView2CookieManager
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CreateCookie(
      [MarshalAs(UnmanagedType.LPWStr), In] string name,
      [MarshalAs(UnmanagedType.LPWStr), In] string value,
      [MarshalAs(UnmanagedType.LPWStr), In] string Domain,
      [MarshalAs(UnmanagedType.LPWStr), In] string Path);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Cookie CopyCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookieParam);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void GetCookies([MarshalAs(UnmanagedType.LPWStr), In] string uri, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetCookiesCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddOrUpdateCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookie([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Cookie cookie);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookies([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string uri);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteCookiesWithDomainAndPath([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.LPWStr), In] string Domain, [MarshalAs(UnmanagedType.LPWStr), In] string Path);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void DeleteAllCookies();
  }
}
