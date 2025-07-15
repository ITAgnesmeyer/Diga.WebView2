namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the kind of process failure, matching <c>COREWEBVIEW2_PROCESS_FAILED_KIND</c>.
    /// </summary>
    public enum ProcessFailedKind
    {
        /// <summary>
        /// The browser process exited.
        /// </summary>
        BrowserProcessExited,
        /// <summary>
        /// The render process exited.
        /// </summary>
        RenderProcessExited,
        /// <summary>
        /// The render process became unresponsive.
        /// </summary>
        RenderProcessUnresponsive,
        /// <summary>
        /// The frame render process exited.
        /// </summary>
        FrameRenderProcessExited,
        /// <summary>
        /// The utility process exited.
        /// </summary>
        UtilityProcessExited,
        /// <summary>
        /// The sandbox helper process exited.
        /// </summary>
        SandboxHelperProcessExited,
        /// <summary>
        /// The GPU process exited.
        /// </summary>
        GpuProcessExited,
        /// <summary>
        /// The PPAPI plugin process exited.
        /// </summary>
        PpapiPluginProcessExited,
        /// <summary>
        /// The PPAPI broker process exited.
        /// </summary>
        PpapiBrokerProcessExited,
        /// <summary>
        /// An unknown process exited.
        /// </summary>
        UnknownProcessExited
    }
}