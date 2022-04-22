// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ContextMenuRequestedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("A1D309EE-C03F-11EB-8529-0242AC130003")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContextMenuRequestedEventArgs
  {
    [DispId(1610678272)]
    ICoreWebView2ContextMenuItemCollection MenuItems { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678273)]
    ICoreWebView2ContextMenuTarget ContextMenuTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678274)]
    tagPOINT Location { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    int SelectedCommandId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678277)]
    int Handled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2Deferral GetDeferral();
  }
}
