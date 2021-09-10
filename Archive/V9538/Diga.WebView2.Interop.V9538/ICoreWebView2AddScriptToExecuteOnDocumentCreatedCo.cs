// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 680EA815-80DF-438D-AA0D-D4F0EB9B8A6C
// Assembly location: O:\webview2\V9538\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("7082ABED-0591-428F-A722-60C2F814546B")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.LPWStr), In] string id);
  }
}
