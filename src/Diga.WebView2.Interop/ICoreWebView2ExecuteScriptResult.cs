// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ExecuteScriptResult
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3A44191-3ED4-47B6-93D0-E02F7F7C4CF1
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2277.86\Diga.WebView2.Interop_safe.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//#nullable disable
namespace Diga.WebView2.Interop
{
  [Guid("0CE15963-3698-4DF7-9399-71ED6CDD8C9F")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ExecuteScriptResult
  {
    [DispId(1610678272)]
    int Succeeded { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    string ResultAsJson { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void TryGetResultAsString([MarshalAs(UnmanagedType.LPWStr)] out string stringResult, out int value);

    [DispId(1610678275)]
    ICoreWebView2ScriptException Exception { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
