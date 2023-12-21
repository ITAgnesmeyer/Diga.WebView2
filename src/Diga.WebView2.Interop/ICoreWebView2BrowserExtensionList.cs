// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2BrowserExtensionList
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E890F85C-2747-4676-BEB3-566B145AA00D
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2210.55\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("2EF3D2DC-BD5F-4F4D-90AF-FD67798F0C2F")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2BrowserExtensionList
  {
    [DispId(1610678272)]
    uint Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2BrowserExtension GetValueAtIndex([In] uint index);
  }
}
