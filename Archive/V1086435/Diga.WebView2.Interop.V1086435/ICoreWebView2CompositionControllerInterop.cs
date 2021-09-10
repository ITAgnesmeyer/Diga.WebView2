// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CompositionControllerInterop
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("8E9922CE-9C80-42E6-BAD7-FCEBF291A495")]
  [ComImport]
  public interface ICoreWebView2CompositionControllerInterop
  {
    [DispId(1610678272)]
    object UIAProvider { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }

    [DispId(1610678273)]
    object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }
  }
}
