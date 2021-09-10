// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2AcceleratorKeyPressedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B5F140DB-135D-4E8A-B1A2-1275CE2FD56A
// Assembly location: O:\webview2\webview2packages\V9488\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("9224476E-D8C3-4EB7-BB65-2FD7792B27CE")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2AcceleratorKeyPressedEventArgs
  {
    [DispId(1610678272)]
    COREWEBVIEW2_KEY_EVENT_KIND KeyEventKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    uint VirtualKey { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    int KeyEventLParam { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    COREWEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678276)]
    int Handled { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
