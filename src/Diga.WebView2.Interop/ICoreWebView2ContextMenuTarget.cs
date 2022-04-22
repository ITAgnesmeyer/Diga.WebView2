// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ContextMenuTarget
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("B8611D99-EED6-4F3F-902C-A198502AD472")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContextMenuTarget
  {
    [DispId(1610678272)]
    COREWEBVIEW2_CONTEXT_MENU_TARGET_KIND Kind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    int IsEditable { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    int IsRequestedForMainFrame { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    string PageUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678276)]
    string FrameUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678277)]
    int HasLinkUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678278)]
    string LinkUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678279)]
    int HasLinkText { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678280)]
    string LinkText { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678281)]
    int HasSourceUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678282)]
    string SourceUri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678283)]
    int HasSelection { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678284)]
    string SelectionText { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }
  }
}
