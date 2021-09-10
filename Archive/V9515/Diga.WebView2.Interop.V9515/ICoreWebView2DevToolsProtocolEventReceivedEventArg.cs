// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2DevToolsProtocolEventReceivedEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4848E93B-2D8E-488A-B413-2977821823D1
// Assembly location: O:\webview2\V9515\WebView2.dll

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
