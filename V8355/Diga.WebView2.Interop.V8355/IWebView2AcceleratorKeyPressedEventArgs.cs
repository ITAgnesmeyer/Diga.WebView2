// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2AcceleratorKeyPressedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("64C29E6D-BA57-4EBA-A14F-71697F4F3D86")]
  [ComImport]
  public interface IWebView2AcceleratorKeyPressedEventArgs
  {
    [DispId(1610678272)]
    WEBVIEW2_KEY_EVENT_TYPE KeyEventType { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    uint VirtualKey { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    int KeyEventLParam { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    WEBVIEW2_PHYSICAL_KEY_STATUS PhysicalKeyStatus { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Handle([In] int handled);
  }
}
