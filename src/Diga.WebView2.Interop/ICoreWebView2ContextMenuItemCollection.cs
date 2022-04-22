// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ContextMenuItemCollection
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("F562A2F5-C415-45CF-B909-D4B7C1E276D3")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContextMenuItemCollection
  {
    [DispId(1610678272)]
    uint Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ContextMenuItem GetValueAtIndex([In] uint index);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveValueAtIndex([In] uint index);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InsertValueAtIndex([In] uint index, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContextMenuItem value);
  }
}
