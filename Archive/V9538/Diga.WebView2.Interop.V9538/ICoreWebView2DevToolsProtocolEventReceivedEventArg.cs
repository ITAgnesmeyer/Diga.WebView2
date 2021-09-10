// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2DevToolsProtocolEventReceivedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("F661B1C2-5FF5-4700-B723-C439034539B4")]
  [ComImport]
  public interface ICoreWebView2DevToolsProtocolEventReceivedEventArgs
  {
    [DispId(1610678272)]
    string ParameterObjectAsJson { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }
  }
}
