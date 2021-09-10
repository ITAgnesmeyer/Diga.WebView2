// Decompiled with JetBrains decompiler
// Type: WebView2.IWebView2NewVersionAvailableEventArgs
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5F0D75F7-60BF-43BB-8231-ACD9063B7411
// Assembly location: O:\macos\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("0256DA7B-2BF7-4B12-8ECA-EFFCB28C2CD8")]
  [ComImport]
  public interface IWebView2NewVersionAvailableEventArgs
  {
    [DispId(1610678272)]
    string NewVersion { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }
  }
}
