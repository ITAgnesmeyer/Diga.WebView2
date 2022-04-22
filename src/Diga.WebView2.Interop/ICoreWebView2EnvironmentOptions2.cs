// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2EnvironmentOptions2
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EA95D0FC-77DE-40CE-8C3C-89517DF28E5B
// Assembly location: O:\webview2\V10118539\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("FF85C98A-1BA7-4A6B-90C8-2B752C89E9E2")]
  [ComImport]
  public interface ICoreWebView2EnvironmentOptions2
  {
    [DispId(1610678272)]
    int ExclusiveUserDataFolderAccess { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [param: In] set; }
  }
}
