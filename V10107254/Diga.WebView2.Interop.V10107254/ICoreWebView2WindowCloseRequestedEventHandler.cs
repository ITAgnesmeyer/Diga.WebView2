// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2WindowCloseRequestedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("5C19E9E0-092F-486B-AFFA-CA8231913039")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2WindowCloseRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
