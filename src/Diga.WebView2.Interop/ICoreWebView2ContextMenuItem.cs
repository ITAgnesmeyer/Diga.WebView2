// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ContextMenuItem
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [Guid("7AED49E3-A93F-497A-811C-749C6B6B6C65")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContextMenuItem
  {
    [DispId(1610678272)]
    string name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    string Label { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678274)]
    int CommandId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    string ShortcutKeyDescription { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678276)]
    IStream Icon { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [DispId(1610678277)]
    COREWEBVIEW2_CONTEXT_MENU_ITEM_KIND Kind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678278)]
    int IsEnabled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678280)]
    int IsChecked { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678282)]
    ICoreWebView2ContextMenuItemCollection Children { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_CustomItemSelected(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CustomItemSelectedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_CustomItemSelected([In] EventRegistrationToken token);
  }
}
