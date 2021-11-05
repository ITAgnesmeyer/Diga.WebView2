// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CursorChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("9DA43CCC-26E1-4DAD-B56C-D8961C94C571")]
  [ComImport]
  public interface ICoreWebView2CursorChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2CompositionController sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
