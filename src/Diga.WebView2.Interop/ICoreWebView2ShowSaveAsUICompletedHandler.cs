// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ShowSaveAsUICompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D13381-11FC-4303-9DB0-23B921C377B0
// Assembly location: D:\temp\webview2\microsoft.web.webview2.1.0.2849.39\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("E24B07E3-8169-5C34-994A-7F6478946A3C")]
  [ComImport]
  public interface ICoreWebView2ShowSaveAsUICompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [In] COREWEBVIEW2_SAVE_AS_UI_RESULT result);
  }
}
