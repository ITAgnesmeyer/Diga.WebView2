// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ScriptException
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A3A44191-3ED4-47B6-93D0-E02F7F7C4CF1
// Assembly location: F:\temp\microsoft.web.webview2.1.0.2277.86\Diga.WebView2.Interop_safe.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

//#nullable disable
namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("054DAE00-84A3-49FF-BC17-4012A90BC9FD")]
  [ComImport]
  public interface ICoreWebView2ScriptException
  {
    [DispId(1610678272)]
    uint LineNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678273)]
    uint ColumnNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678274)]
    string name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678275)]
    string Message { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678276)]
    string ToJson { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }
  }
}
