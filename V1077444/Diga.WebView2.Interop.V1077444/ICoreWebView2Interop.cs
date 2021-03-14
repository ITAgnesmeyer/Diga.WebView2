// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Interop
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AAF9543A-0FE1-46E7-BB2C-D24EA0535C0F
// Assembly location: O:\webview2\v1077444\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("912B34A7-D10B-49C4-AF18-7CB7E604E01A")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2Interop
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void AddHostObjectToScript([MarshalAs(UnmanagedType.LPWStr), In] string name, [MarshalAs(UnmanagedType.Struct), In] ref object @object);
  }
}
