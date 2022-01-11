// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CompositionControllerInterop
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("8E9922CE-9C80-42E6-BAD7-FCEBF291A495")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CompositionControllerInterop
  {
    [DispId(1610678272)]
    object UIAProvider { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; }

    [DispId(1610678273)]
    object RootVisualTarget { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.IUnknown)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: MarshalAs(UnmanagedType.IUnknown), In] set; }
  }
}
