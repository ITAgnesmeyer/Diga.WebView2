// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2PermissionSettingCollectionView
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1241A3C3-E886-4508-B746-7F7141E4C294
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1722.45\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("F5596F62-3DE5-47B1-91E8-A4104B596B96")]
  [ComImport]
  public interface ICoreWebView2PermissionSettingCollectionView
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2PermissionSetting GetValueAtIndex([In] uint index);

    [DispId(1610678273)]
    uint Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
