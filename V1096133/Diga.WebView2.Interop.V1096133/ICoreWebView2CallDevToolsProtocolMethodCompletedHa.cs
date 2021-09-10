// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("5C4889F0-5EF6-4C5A-952C-D8F1B92D0574")]
  [ComImport]
  public interface ICoreWebView2CallDevToolsProtocolMethodCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.LPWStr), In] string returnObjectAsJson);
  }
}
