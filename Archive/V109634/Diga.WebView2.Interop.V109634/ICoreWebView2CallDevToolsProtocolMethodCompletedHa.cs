// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0C0240C-E7D7-45C8-B13A-ACBB49432772
// Assembly location: O:\webview2\V9622\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("5C4889F0-5EF6-4C5A-952C-D8F1B92D0574")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.LPWStr), In] string returnObjectAsJson);
  }
}
