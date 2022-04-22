// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ContextMenuRequestedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("04D3FE1D-AB87-42FB-A898-DA241D35B63C")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ContextMenuRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ContextMenuRequestedEventArgs args);
  }
}
