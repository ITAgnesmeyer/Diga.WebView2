// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ProcessInfosChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B1615030-5202-42C2-A0A8-1F7B8FE362ED
// Assembly location: O:\webview2\V10110844\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("F4AF0C39-44B9-40E9-8B11-0484CFB9E0A1")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ProcessInfosChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Environment sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
