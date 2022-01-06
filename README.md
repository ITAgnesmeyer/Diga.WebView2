# Diga.WebView2
WebView2 Wrapper For => [Edge Chromium](https://www.microsoft.com/edge "Edge Chromium")

Microsoft [WebView2](https://docs.microsoft.com/microsoft-edge/hosting/webview2 "WebView2")

### Nuget Packages:
There are NUGET-PACKAGES 

- Diga.WebView2.Interop => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Interop/ "NuGet")
- Diga.WebView2.Wrapper => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wrapper/ "NuGet")
- Diga.WebView2.WinForms => [NuGet](https://www.nuget.org/packages/Diga.WebView2.WinForms/ "NuGet")
- Diga.WebView2.Wpf => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wpf/ "NuGet")

[WebView2 Runtime](https://developer.microsoft.com/en-us/microsoft-edge/webview2/)

### Why this project was created.
Microsoft provides a WebControl for Windows forms.
However, this is based on Internet Explorer. This cannot represent various features.
This does not support WebAssemblies.
The motivation for this project, however, was to load and display WebAssembly applications (BLAZOR-SITES).
It should also be possible to work completely without an HTTP server.

### Addendum:
From version 0.9.515-prerelease there will be a WinForms control included. (finally).

Currently, however, it is not possible to create a real Any-CPU version with this control.
If Any-CPU excludes the hook (pefere x86) on a 64bit machine, a run-time error occurs. This error occurs when the WebView2 NuGet-Package is bound. 
See => Why is the "microsoft.web.webview2" package not linked.

### Microsoft and WebView2
Microsoft provides Edge Chromium, a modern browser for Windows.
With the COM-based interface of WebView2, this can also be programmed.
Unfortunately, this option is officially reserved only for C++ programmers.
This is to be fixed with this project.

### packages are currently supported.
microsoft.web.webview2

- Version 1.0.992.28 is the current Version on Client - PC's
- Version 1.0.1020.30 is the current Version on Client - PC's

WebView2 [Release-Notes](https://docs.microsoft.com/de-de/microsoft-edge/webview2/releasenotes)

### Why is the microsoft.web.webview2 package not linked?
The packages are not linked because this does not allow the mapping of Any CPU.
The packages are always added only based on the setting of the projects.
The API calls in this project are designed to draw the correct DLL depending on CPU usage.
Therefore, the DLL's were included in the project.
The NATIVEN-DLL's can then be found in the bin directory under native/x86 or native/x64.


### Package version:
This means the version of the WebView2 packages.

- V10105431 => [microsoft.web.webview2 1.0.1054.31](https://www.nuget.org/packages/Microsoft.Web.WebView2/1.0.1054.31)
- V10102030 => [microsoft.web.webview2 1.0.1020.30](https://www.nuget.org/packages/Microsoft.Web.WebView2/1.0.1020.30)

### How were the interop sources created?
The Microsoft microsoft.web.webview2 package contains webview2.tlb.
The basic file was created with tlbImp.exe.
Because the resulting DLL does not correctly reflect interfaces, they need to be revised.
Therefore, the DLL, with JetBrains-DotPeek, has been converted to sources and adjusted accordingly.

### Why a separation between Interop, Wrapper and WinForms
The separation is maintained because the packages can be useful in different projects.
So it may be that only the interop and wrapper packages are used in some projects.
Or it may be that only the Interop package is needed.

#### Why I get an error when I try to add the core control in a WinForms application in the designer.
This seems to be related to Visual Studio.



## Windows Forms
If you use net Framework. You have to modify the Diga.WebView2.Interop.dll Reference.

Set Embed Interop Types to False!
This copies the DLL into the program directory. If you do not make this setting, there will be an error when starting the application.

WinForms is STAThread. The access to the component must therefore also be thread-safe, as is usual in WinForms. You should never call properties or functions of a component directly from a Task. Use a delegate to do this, if necessary.

```c#
public void SendMessage(string message)
{
   if (this.webView1.InvokeRequired)
   {
      Action<string> ac = SendMessage;
      this.webView1.Invoke(ac, message);
   }
   else
   {
      this.webView1.SendMessage(message);    
   }
}

public async Task InvokeSendMessage(string msg)
{
   await Task.Run(() => this.SendMessage(msg));
}
```

## DOM Objects
The Windows Forms project now supports DOM objects.
You can retrieve the DOM - Window object and the DOM - Document object directly by using the GetDOMWidow() and GetDOMDocument() functions.
It should be noted that calls are asynchronous.


###### This text was automatically translated with the [Microsoft translator](https://www.bing.com/translator "Microsoft translator").





