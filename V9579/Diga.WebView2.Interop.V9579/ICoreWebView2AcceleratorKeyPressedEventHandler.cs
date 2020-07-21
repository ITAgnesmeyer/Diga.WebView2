// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2AcceleratorKeyPressedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("A7D303F9-503C-4B7E-BC40-5C7CE6CABAAA")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2AcceleratorKeyPressedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2Controller sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2AcceleratorKeyPressedEventArgs args);
  }
}
