// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2NewVersionAvailableEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("9E21312F-6FE7-4118-8CA1-6317C9CD627B")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IWebView2NewVersionAvailableEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2Environment webViewEnvironment, [MarshalAs(UnmanagedType.Interface), In] IWebView2NewVersionAvailableEventArgs args);
  }
}
