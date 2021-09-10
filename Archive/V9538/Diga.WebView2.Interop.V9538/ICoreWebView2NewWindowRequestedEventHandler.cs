// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2NewWindowRequestedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("ACAA30EF-A40C-47BD-9CB9-D9C2AADC9FCB")]
  [ComImport]
  public interface ICoreWebView2NewWindowRequestedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2NewWindowRequestedEventArgs args);
  }
}
