// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2ScriptDialogOpeningEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("8EAF9A50-2AF9-45DA-9AC5-F80F4147180E")]
  [ComImport]
  public interface IWebView2ScriptDialogOpeningEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] IWebView2WebView webview, [MarshalAs(UnmanagedType.Interface), In] IWebView2ScriptDialogOpeningEventArgs args);
  }
}
