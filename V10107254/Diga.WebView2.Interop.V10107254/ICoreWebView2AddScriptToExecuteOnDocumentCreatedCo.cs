// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("B99369F3-9B11-47B5-BC6F-8E7895FCEA17")]
  [ComImport]
  public interface ICoreWebView2AddScriptToExecuteOnDocumentCreatedCompletedHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Error), In] int errorCode, [MarshalAs(UnmanagedType.LPWStr), In] string id);
  }
}
