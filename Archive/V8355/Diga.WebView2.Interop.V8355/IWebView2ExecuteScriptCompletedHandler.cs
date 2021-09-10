// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2ExecuteScriptCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("F5AC0E3B-8B92-45E5-ABEF-DB8518EFFF27")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface IWebView2ExecuteScriptCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.LPWStr), In] string resultObjectAsJson);
  }
}
