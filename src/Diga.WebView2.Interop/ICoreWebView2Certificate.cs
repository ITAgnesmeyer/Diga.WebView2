// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Certificate
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 78C6AA08-CDE2-4921-BDB5-AF4A988C5D7D
// Assembly location: O:\webview2\microsoft.web.webview2.1.0.1264.42\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("C5FB2FCE-1CAC-4AEE-9C79-5ED0362EAAE0")]
  [ComImport]
  public interface ICoreWebView2Certificate
  {
    [DispId(1610678272)]
    string Subject { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678273)]
    string Issuer { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678274)]
    double ValidFrom { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678275)]
    double ValidTo { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [DispId(1610678276)]
    string DerEncodedSerialNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [DispId(1610678277)]
    string DisplayName { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    [return: MarshalAs(UnmanagedType.LPWStr)]
    string ToPemEncoding();

    [DispId(1610678279)]
    ICoreWebView2StringCollection PemEncodedIssuerCertificateChain { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.Interface)] get; }
  }
}
