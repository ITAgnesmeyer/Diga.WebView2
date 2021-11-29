// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Interop
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1E8B0323-528E-4C9C-8FF8-A486637C87E1
// Assembly location: O:\webview2\V1096133\Diga.WebView2.Interop.dll

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
