// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2WebMessageReceivedEventHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("199328C8-9964-4F5F-84E6-E875B1B763D6")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2WebMessageReceivedEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2WebMessageReceivedEventArgs args);
  }
}
