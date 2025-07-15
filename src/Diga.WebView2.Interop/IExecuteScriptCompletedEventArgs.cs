using System;
using System.Threading.Tasks;

namespace Diga.WebView2.Interop
{
    /// <summary>
    /// Defines events for a web view control, allowing subscribers to handle script execution completion, document
    /// loading, and document unloading events.
    /// </summary>
    public interface IWebViewControlEvents
    {
        /// <summary>
        /// Occurs when the execution of a script has completed.
        /// </summary>
        /// <remarks>This event is triggered after a script execution finishes, providing the results or
        /// status of the execution through the <see cref="IExecuteScriptCompletedEventArgs"/> parameter. Subscribers
        /// can use this event to handle post-execution logic, such as processing results or handling errors.</remarks>
        event EventHandler<IExecuteScriptCompletedEventArgs> ExecuteScriptCompleted;
        /// <summary>
        /// Occurs when a document is being loaded.
        /// </summary>
        /// <remarks>Subscribe to this event to perform actions when a document starts loading.  This
        /// event is typically used to update the UI or log the loading process.</remarks>
        event EventHandler DocumentLoading;
        /// <summary>
        /// Occurs when a document is unloaded.
        /// </summary>
        /// <remarks>This event is triggered when the document is no longer needed and is being removed
        /// from memory. Subscribers can use this event to perform cleanup operations or release resources associated
        /// with the document.</remarks>
        event EventHandler DocumentUnload;
    }

    /// <summary>
    /// Provides methods to execute JavaScript code within a web view control.
    /// </summary>
    /// <remarks>This interface allows both asynchronous and synchronous execution of JavaScript code. It is
    /// designed to be used with web view controls that support script execution.</remarks>
    public interface IWebViewControlScript
    {
        
        /// <summary>
        /// Executes the specified JavaScript code asynchronously in the current context.
        /// </summary>
        /// <param name="javaScript">The JavaScript code to execute. This string must be a valid JavaScript expression or statement.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the result of the JavaScript
        /// execution as a string.</returns>
        Task<string> ExecuteScriptAsync(string javaScript);

        /// <summary>
        /// Executes the specified JavaScript code synchronously and returns the result as a string.
        /// </summary>
        /// <param name="javaScript">The JavaScript code to execute. Cannot be null or empty.</param>
        /// <returns>The result of the JavaScript execution as a string. Returns an empty string if the execution yields no
        /// result.</returns>
        string ExecuteScriptSync(string javaScript);

        /// <summary>
        /// Executes the specified JavaScript code and returns the result as a string.
        /// </summary>
        /// <param name="javaScript">The JavaScript code to execute. Cannot be null or empty.</param>
        /// <returns>The result of the JavaScript execution as a string. Returns an empty string if the execution yields no
        /// result.</returns>
        string InvokeScript(string javaScript);

    }

    /// <summary>
    /// Represents a control that provides web browsing capabilities within an application.
    /// </summary>
    /// <remarks>The <c>IWebViewControl</c> interface combines the functionalities of
    /// <c>IWebViewControlScript</c> and <c>IWebViewControlEvents</c>, allowing for script execution and event handling
    /// in a web view context. Implement this interface to integrate web content rendering and interaction within your
    /// application.</remarks>
    public interface IWebViewControl:IWebViewControlScript,IWebViewControlEvents
    {

    }

    /// <summary>
    /// Provides data for the ExecuteScriptCompleted event.
    /// </summary>
    public interface IExecuteScriptCompletedEventArgs
    {
        /// <summary>
        /// Gets the error code of the script execution.
        /// </summary>
        int ErrorCode { get; }
        /// <summary>
        /// Gets the identifier for the script execution request.
        /// </summary>
        string Id { get; }
        /// <summary>
        /// Gets the result object as a JSON string.
        /// </summary>
        string ResultObjectAsJson { get; }
    }
}