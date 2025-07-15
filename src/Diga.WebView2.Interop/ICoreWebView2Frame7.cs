// Decompiled with JetBrains decompiler
// Type: Diga.WebView2.Interop.ICoreWebView2Frame7
// Assembly: Diga.WebView2.Interop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B58873C5-7732-4F0F-96EB-A45D9CAFD84E
// Assembly location: D:\tmp\Microsoft.Web.WebView2.1.0.3351.48\Diga.WebView2.Interop.dll

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace Diga.WebView2.Interop
{
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [Guid("3598CFA2-D85D-5A9F-9228-4DDE1F59EC64")]
  [ComImport]
  public interface ICoreWebView2Frame7 : ICoreWebView2Frame6
  {
    [DispId(1610678272)]
    new string name { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] [return: MarshalAs(UnmanagedType.LPWStr)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NameChanged(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameNameChangedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NameChanged([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void AddHostObjectToScriptWithOrigins(
      [ In] string name,
      [ In] ref object @object,
      [In] uint originsCount,
      [MarshalAs(UnmanagedType.LPWStr), In] ref string origins);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void RemoveHostObjectFromScript([MarshalAs(UnmanagedType.LPWStr), In] string name);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_Destroyed(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameDestroyedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_Destroyed([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new int IsDestroyed();

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NavigationStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameNavigationStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NavigationStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ContentLoading(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameContentLoadingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ContentLoading([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_NavigationCompleted(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameNavigationCompletedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_NavigationCompleted([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_DOMContentLoaded(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameDOMContentLoadedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_DOMContentLoaded([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void ExecuteScript([MarshalAs(UnmanagedType.LPWStr), In] string javaScript, [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2ExecuteScriptCompletedHandler handler);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PostWebMessageAsJson([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsJson);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PostWebMessageAsString([MarshalAs(UnmanagedType.LPWStr), In] string webMessageAsString);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_WebMessageReceived(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameWebMessageReceivedEventHandler handler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_WebMessageReceived([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_PermissionRequested(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FramePermissionRequestedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_PermissionRequested([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void PostSharedBufferToScript(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2SharedBuffer sharedBuffer,
      [In] COREWEBVIEW2_SHARED_BUFFER_ACCESS access,
      [MarshalAs(UnmanagedType.LPWStr), In] string additionalDataAsJson);

    [DispId(1610940416)]
    new uint FrameId { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)] get; }

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void add_ScreenCaptureStarting(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameScreenCaptureStartingEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    new void remove_ScreenCaptureStarting([In] EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void add_FrameCreated(
      [MarshalAs(UnmanagedType.Interface), In] ICoreWebView2FrameChildFrameCreatedEventHandler eventHandler,
      out EventRegistrationToken token);

    [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
    void remove_FrameCreated([In] EventRegistrationToken token);
  }
}
