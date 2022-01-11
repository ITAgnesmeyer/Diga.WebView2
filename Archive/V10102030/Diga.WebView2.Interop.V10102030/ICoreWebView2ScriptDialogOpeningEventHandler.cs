// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2ScriptDialogOpeningEventHandler
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("EF381BF9-AFA8-4E37-91C4-8AC48524BDFB")]
  [ComImport]
  public interface ICoreWebView2ScriptDialogOpeningEventHandler
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Invoke([MarshalAs(UnmanagedType.Interface), In] ICoreWebView2 sender, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ScriptDialogOpeningEventArgs args);
  }
}
