// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Deferral
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("C10E7F7B-B585-46F0-A623-8BEFBF3E4EE0")]
  [ComImport]
  public interface ICoreWebView2Deferral
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Complete();
  }
}
