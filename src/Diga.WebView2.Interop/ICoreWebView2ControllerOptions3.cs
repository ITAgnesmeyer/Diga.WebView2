// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ControllerOptions3
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B58873C5-7732-4F0F-96EB-A45D9CAFD84E
// Assembly location: D:\tmp\Microsoft.Web.WebView2.1.0.3351.48\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Interop
{
  [Guid("B32B191A-8998-57CA-B7CB-E04617E4CE4A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ControllerOptions3 : ICoreWebView2ControllerOptions2
  {
    [DispId(1610678272)]
    new string ProfileName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.LPWStr), In] set; }

    [DispId(1610678274)]
    new int IsInPrivateModeEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }

    [DispId(1610743808)]
    new string ScriptLocale { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.LPWStr), In] set; }

    [DispId(1610809344)]
    COREWEBVIEW2_COLOR DefaultBackgroundColor { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
