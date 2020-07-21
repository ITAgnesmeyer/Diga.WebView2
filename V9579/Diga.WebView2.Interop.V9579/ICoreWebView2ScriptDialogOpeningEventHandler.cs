// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2ScriptDialogOpeningEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6399528E-A51C-4F53-9554-F4718EFA3992
// Assembly location: O:\webview2\V9579\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("72D93789-2727-4A9B-A4FC-1B2609CBCBE3")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ScriptDialogOpeningEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScriptDialogOpeningEventArgs args);
  }
}
