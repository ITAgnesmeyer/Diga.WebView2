// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CustomItemSelectedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("49E1D0BC-FE9E-4481-B7C2-32324AA21998")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CustomItemSelectedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContextMenuItem sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
