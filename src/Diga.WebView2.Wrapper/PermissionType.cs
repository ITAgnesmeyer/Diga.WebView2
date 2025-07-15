namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Specifies the kind of permission requested or used in WebView2, matching <c>COREWEBVIEW2_PERMISSION_KIND</c>.
    /// </summary>
    public enum PermissionType
    {
        /// <summary>
        /// Unknown permission kind.
        /// </summary>
        UnknownPermission,
        /// <summary>
        /// Microphone access permission.
        /// </summary>
        Microphone,
        /// <summary>
        /// Camera access permission.
        /// </summary>
        Camera,
        /// <summary>
        /// Geolocation access permission.
        /// </summary>
        Geolocation,
        /// <summary>
        /// Notifications permission.
        /// </summary>
        Notifications,
        /// <summary>
        /// Other sensors permission.
        /// </summary>
        OtherSensors,
        /// <summary>
        /// Clipboard read permission.
        /// </summary>
        ClipboardRead,
        /// <summary>
        /// Multiple automatic downloads permission.
        /// </summary>
        MultipleAutomaticDownloads,
        /// <summary>
        /// File read/write permission.
        /// </summary>
        FileReadWrite,
        /// <summary>
        /// Autoplay permission.
        /// </summary>
        Autoplay,
        /// <summary>
        /// Local fonts permission.
        /// </summary>
        LocalFonts,
        /// <summary>
        /// MIDI system exclusive messages permission.
        /// </summary>
        MidiSystemExclusiveMessages,
        /// <summary>
        /// Window management permission.
        /// </summary>
        WindowManagement,
    }
}