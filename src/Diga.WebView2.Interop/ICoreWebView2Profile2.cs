// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Profile2
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78C6AA08-CDE2-4921-BDB5-AF4A988C5D7D
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1264.42\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("FA740D4B-5EAE-4344-A8AD-74BE31925397")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2Profile2 : ICoreWebView2Profile
  {
    [DispId(1610678272)]
    new string ProfileName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    new int IsInPrivateModeEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    new string ProfilePath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678275)]
    new string DefaultDownloadFolderPath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.LPWStr), In] set; }

    [DispId(1610678277)]
    new COREWEBVIEW2_PREFERRED_COLOR_SCHEME PreferredColorScheme { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingData(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingDataInTimeRange(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [In] double startTime,
      [In] double endTime,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void ClearBrowsingDataAll(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);
  }
}
