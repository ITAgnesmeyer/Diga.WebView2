namespace Diga.WebView2.Wrapper
{
    public enum ProcessFailedKind
    {
        BrowserProcessExited,
        RenderProcessExited,
        RenderProcessUnresponsive,
        FrameRenderProcessExited,
        SandboxHelperProcessExited,
        GpuProcessExited,
        PpapiPluginProcessExited,
        PpapiBrokerProcessExited,
        UnknownProcessExited
    }
}