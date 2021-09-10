// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2CapturePreviewCompletedHandler
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("5755B27A-3FCD-4E01-B368-06834A5AFCDC")]
  [ComImport]
  public interface IWebView2CapturePreviewCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int result);
  }
}
