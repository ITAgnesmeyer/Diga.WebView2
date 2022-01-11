namespace Diga.WebView2.Wrapper
{
    public enum ProcessFailedKind
    {
        BrowserProcessExited,
        RenderProcessExited,
        RenderProcessUnresponsive,
        FrameRenderProcessExited,
        UtilityProcessExited,
        SandboxHelperProcessExited,
        GpuProcessExited,
        PpapiPluginProcessExited,
        PpapiBrokerProcessExited,
        UnknownProcessExited
    }
}