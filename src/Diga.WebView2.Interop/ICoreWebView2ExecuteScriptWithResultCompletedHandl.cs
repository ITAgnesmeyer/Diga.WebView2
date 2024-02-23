// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ExecuteScriptWithResultCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3A44191-3ED4-47B6-93D0-E02F7F7C4CF1
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2277.86\Diga.WebView2.Interop_safe.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//#nullable disable
namespace Diga.WebView2.Interop
{
  [Guid("1BB5317B-8238-4C67-A7FF-BAF6558F289D")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ExecuteScriptWithResultCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptResult result);
  }
}
