using Diga.WebView2.Interop;

// ReSharper disable once CheckNamespace
namespace Diga.WebView2.Wrapper
{
    /// <summary>
    /// Represents the status of a physical key event, providing details about the key's state during the event.
    /// </summary>
    /// <remarks>This class encapsulates information about a physical key event, such as repeat count, scan
    /// code, and key state flags. It is typically used to interpret the state of a key during keyboard input
    /// processing.</remarks>
    public class PhysicalKeyStatus
    {
        private readonly COREWEBVIEW2_PHYSICAL_KEY_STATUS _Status;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhysicalKeyStatus"/> class with the specified key status.
        /// </summary>
        /// <param name="status">The physical key status to initialize the instance with.</param>
        public PhysicalKeyStatus(COREWEBVIEW2_PHYSICAL_KEY_STATUS status)
        {
            this._Status = status;
        }

        /// <summary>
        /// Gets the number of times an operation is repeated.
        /// </summary>
        public uint RepeatCount => this._Status.RepeatCount;
        /// <summary>
        /// Gets the scan code associated with the current status.
        /// </summary>
        public uint ScanCode => this._Status.ScanCode;

        /// <summary>
        /// Gets a value indicating whether the key is an extended key.
        /// </summary>
        public int IsExtendedKey => this._Status.IsExtendedKey;

        /// <summary>
        /// Gets a value indicating whether the menu key is currently pressed.
        /// </summary>
        public int IsMenuKeyDown => this._Status.IsMenuKeyDown;

        /// <summary>
        /// Gets the status indicating whether a key was previously pressed.
        /// </summary>
        public int WasKeyDown => this._Status.WasKeyDown;

        /// <summary>
        /// Gets the status indicating whether a key has been released.
        /// </summary>
        public int IsKeyReleased => this._Status.IsKeyReleased;
    }
}