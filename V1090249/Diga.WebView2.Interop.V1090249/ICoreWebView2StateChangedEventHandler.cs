// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2StateChangedEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92B97282-7222-4AB4-B087-3F0FC910320A
// Assembly location: O:\webview2\v1090249\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("81336594-7EDE-4BA9-BF71-ACF0A95B58DD")]
  [ComImport]
  public interface ICoreWebView2StateChangedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2DownloadOperation sender, [MarshalAs(UnmanagedType.IUnknown), In] object args);
  }
}
