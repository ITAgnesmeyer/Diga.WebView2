// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2PrintToPdfCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 768C7F4D-BDF8-4A7A-A16F-3879CF339892
// Assembly location: O:\webview2\V10102030\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("CCF1EF04-FD8E-4D5F-B2DE-0983E41B8C36")]
  [ComImport]
  public interface ICoreWebView2PrintToPdfCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, int isSuccessful);
  }
}
