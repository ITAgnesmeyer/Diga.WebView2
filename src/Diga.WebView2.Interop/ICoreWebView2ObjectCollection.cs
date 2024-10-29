// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ObjectCollection
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("5CFEC11C-25BD-4E8D-9E1A-7ACDAEEEC047")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ObjectCollection : ICoreWebView2ObjectCollectionView
  {
    [DispId(1610678272)]
    new uint Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.IUnknown)]
    new object GetValueAtIndex([In] uint index);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void RemoveValueAtIndex([In] uint index);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void InsertValueAtIndex([In] uint index, [MarshalAs(UnmanagedType.IUnknown), In] object value);
  }
}
