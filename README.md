# Diga.WebView2
WebView2 Wrapper

### Nuget Packages:
There are NUGET-PACKAGES for V8355

- Diga.WebView2.Interop => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Interop/ "NuGet")
- Diga.WebView2.Wrapper => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wrapper/ "NuGet")
- Diga.WebView2.WinForms => [NuGet](https://www.nuget.org/packages/Diga.WebView2.WinForms/ "NuGet")


### Why this project was created.
Microsoft provides a WebControl for Windows Forms.
However, this is based on Internet Explorer. It cannot display various features.
So WebAssemblys are not supported.
The motivation for this project was to load and display WebAssembly applications.
It should also be possible to work completely without an HTTP server.
This has already been implemented for WebView2.0.8.355.

### Microsoft and WebView2
With Edge Chromium, Microsoft provides a modern browser on Windows.
With the COM-based interface of WebView2 this can also be programmed.
Unfortunately, this option is officially reserved for C ++ programmers.
This project is intended to fix this.

### 3 packages are currently supported.
microsoft.web.webview2

- WebView2=> 0.8.355
- WebView2=> 0.9.430
- WebView2=> 0.9.488

Since Microsoft has completely changed the interface between version 0.8 and 0.9.
3 projects are necessary.

- Version 0.9.430 is equipped with completely different interfaces.
- Version 0.8.355 is the right version for the current installation of Edge Chromium.
- Version 0.9.430 only runs with Edge Chromium Dev
- Version 0.9.488 only runs with Edge Chromium Dev

### Why are the packages not linked?
The packages are not linked, since this does not allow the mapping of Any CPU.
Since the packages are only added based on the respective setting of the projects.
The API calls are designed here so that the correct DLL is pulled depending on the CPU usage.
Therefore the DLL's were included in the project.
The NATIVEN DLLs can then be found in the bin directory under native / x86 or native / x64.


### Why are the sources in the projects only linked?
It may be temporary.
Currently, reference is made to the framework sources in the STD and CORE projects.
This has the advantage that the sources only have to be processed once and are thus kept the same.


### Name of the project files.
In order to enable quick changes between the WebView2 versions, the name spaces are kept the same.
So it should be possible later in the target project simply using the
linked package to decide which version of WebView2 should be used.

- Diga.WebView2.Interop. {Framework}. {PakteVersion}
- Diga.WebView2.Wrapper. {Framework}. {PaketVersion}
- Diga.WebView2.WinForms. {Framework}. {PaketVersion}


### Framework:
- Std => Standard 2.1
- Core => Dotnet core 3.1
- no deposit => NET framework 4.7.2


### Why is there a difference between Std and Framework at all?
Since Microsoft decided to keep Std version 2.1 no longer compatible with the NET framework,
separation is mandatory.
According to Microsoft, STD 2.0 is no longer supported.


### Package version:
This means the version of the WebView2 packages.

- V8355 => microsoft.web.webview2 0.8.355
- V9430 => microsoft.web.webview2 0.9.430
- V9488 => microsoft.web.webview2 0.9.488


### How were the interop sources created?
In the Microsoft microsoft.web.webview2 package, the WebView2.tlb file is included.
The basic file was created with tlbImp.exe.
Since the resulting DLL does not correctly map the interfaces, they must be revised.
Therefore, the DLL was converted into sources with JetBrains-DotPeek and adapted accordingly.

### Why a separation between Interop, Wrapper and WinForms
The separation is maintained because the packages can be useful in different projects.
So it may be that only the interop and wrapper packages are used in some projects.
Or it may be that only the Interop package is needed.

#### Why I get an error when I try to add the core control in a WinForms application in the designer.
This seems to be related to Visual Studio.

### AddRemoteObject => COM interop
It is possible to transfer a Dot-Net object to the web browser as a remote object. This is also possible if the transferred object is not marked as ComVisible. During my tests I was able to set and read out properties. However, I have not been able to call functions without errors. Neither with parameters nor with and also not with and without return.







