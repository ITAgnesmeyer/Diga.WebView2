// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Profile8
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E890F85C-2747-4676-BEB3-566B145AA00D
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2210.55\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("FBF70C2F-EB1F-4383-85A0-163E92044011")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2Profile8 : ICoreWebView2Profile7
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
    new void ClearBrowsingData(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClearBrowsingDataInTimeRange(
      [In] COREWEBVIEW2_BROWSING_DATA_KINDS dataKinds,
      [In] double startTime,
      [In] double endTime,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ClearBrowsingDataAll(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ClearBrowsingDataCompletedHandler handler);

    [DispId(1610809344)]
    new COREWEBVIEW2_TRACKING_PREVENTION_LEVEL PreferredTrackingPreventionLevel { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void SetPermissionState(
      [In] COREWEBVIEW2_PERMISSION_KIND PermissionKind,
      [MarshalAs(UnmanagedType.LPWStr), In] string origin,
      [In] COREWEBVIEW2_PERMISSION_STATE State,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SetPermissionStateCompletedHandler completedHandler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetNonDefaultPermissionSettings(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2GetNonDefaultPermissionSettingsCompletedHandler completedHandler);

    [DispId(1610940416)]
    new ICoreWebView2CookieManager CookieManager { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1611005952)]
    new int IsPasswordAutosaveEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1611005954)]
    new int IsGeneralAutofillEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddBrowserExtension(
      [MarshalAs(UnmanagedType.LPWStr), In] string extensionFolderPath,
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProfileAddBrowserExtensionCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void GetBrowserExtensions(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProfileGetBrowserExtensionsCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Delete();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_Deleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ProfileDeletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_Deleted([In] EventRegistrationToken token);
  }
}
