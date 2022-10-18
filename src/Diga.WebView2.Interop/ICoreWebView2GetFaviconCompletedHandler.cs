// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2GetFaviconCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ED88F383-EEB9-472A-9573-53250CD6B18B
// Assembly location: O:\webview2\Microsoft.Web.WebView2.1.0.1370.28\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Diga.WebView2.Interop
{
  [Guid("A2508329-7DA8-49D7-8C05-FA125E4AEE8D")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2GetFaviconCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.Interface), In] IStream faviconStream);
  }
}
