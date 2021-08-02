// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2FrameCreatedEventArgs
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92B97282-7222-4AB4-B087-3F0FC910320A
// Assembly location: O:\webview2\v1090249\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("4D6E7B5E-9BAA-11EB-A8B3-0242AC130003")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2FrameCreatedEventArgs
  {
    [DispId(1610678272)]
    ICoreWebView2Frame Frame { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
