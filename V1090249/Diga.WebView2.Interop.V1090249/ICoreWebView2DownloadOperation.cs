// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2DownloadOperation
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 92B97282-7222-4AB4-B087-3F0FC910320A
// Assembly location: O:\webview2\v1090249\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [Guid("3D6B6CF2-AFE1-44C7-A995-C65117714336")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  public interface ICoreWebView2DownloadOperation
  {
    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_BytesReceivedChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2BytesReceivedChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_BytesReceivedChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_EstimatedEndTimeChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2EstimatedEndTimeChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_EstimatedEndTimeChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_StateChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2StateChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_StateChanged([In] EventRegistrationToken token);

    [DispId(1610678278)]
    string uri { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678279)]
    string ContentDisposition { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678280)]
    string MimeType { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678281)]
    long TotalBytesToReceive { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678282)]
    long BytesReceived { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678283)]
    string EstimatedEndTime { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678284)]
    string ResultFilePath { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678285)]
    COREWEBVIEW2_DOWNLOAD_STATE State { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678286)]
    COREWEBVIEW2_DOWNLOAD_INTERRUPT_REASON InterruptReason { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Cancel();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Pause();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void Resume();

    [DispId(1610678290)]
    int CanResume { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }
  }
}
