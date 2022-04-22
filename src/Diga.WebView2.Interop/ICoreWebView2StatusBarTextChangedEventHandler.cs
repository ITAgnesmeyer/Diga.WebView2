// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2StatusBarTextChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("A5E3B0D0-10DF-4156-BFAD-3B43867ACAC6")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2StatusBarTextChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
