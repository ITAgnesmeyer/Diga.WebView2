// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ProcessInfoCollection
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1615030-5202-42C2-A0A8-1F7B8FE362ED
// Assembly location: O:\webview2\V10110844\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("402B99CD-A0CC-4FA5-B7A5-51D86A1D2339")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ProcessInfoCollection
  {
    [DispId(1610678272)]
    uint Count { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.Interface)]
    ICoreWebView2ProcessInfo GetValueAtIndex([In] uint index);
  }
}
