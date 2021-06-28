// Decompiled with JetBrains decompiler
// Type: WebView2.ICoreWebView2ProcessFailedEventArgs2
// Assembly: WebView2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CB197DC1-34BC-456D-8BC3-B58B9CD2508E
// Assembly location: O:\webview2\v1086435\WebView2.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("4DAB9422-46FA-4C3E-A5D2-41D2071D3680")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2ProcessFailedEventArgs2 : ICoreWebView2ProcessFailedEventArgs
  {
    [DispId(1610678272)]
    new COREWEBVIEW2_PROCESS_FAILED_KIND ProcessFailedKind { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610743808)]
    COREWEBVIEW2_PROCESS_FAILED_REASON reason { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610743809)]
    int ExitCode { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610743810)]
    string ProcessDescription { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610743811)]
    ICoreWebView2FrameInfoCollection FrameInfosForFailedProcess { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
