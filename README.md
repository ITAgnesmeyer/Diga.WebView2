# Diga.WebView2
WebView2 Wrapper For => [Edge Chromium](https://www.microsoft.com/edge "Edge Chromium")

Microsoft [WebView2](https://docs.microsoft.com/microsoft-edge/hosting/webview2 "WebView2")

### Nuget Packages:
There are NUGET-PACKAGES for V8355

- Diga.WebView2.Interop => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Interop/ "NuGet")
- Diga.WebView2.Wrapper => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wrapper/ "NuGet")
- Diga.WebView2.WinForms => [NuGet](https://www.nuget.org/packages/Diga.WebView2.WinForms/ "NuGet")


### Why this project was created.
Microsoft provides a WebControl for Windows forms.
However, this is based on Internet Explorer. This cannot represent various features.
This does not support WebAssemblies.
The motivation for this project, however, was to load and display WebAssembly applications (BLAZOR-SITES).
It should also be possible to work completely without an HTTP server.
This has already been implemented for WebView2.0.8.355.

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

### 3 packages are currently supported.
microsoft.web.webview2

- WebView2=> 0.8.355
- WebView2=> 0.9.430
- WebView2=> 0.9.488

Since Microsoft has completely changed the interface between version 0.8 and 0.9.
3 projects are necessary.

- Version 0.9.430 is equipped with completely different interfaces.
- Version 0.8.355 no longer works on Client - PC.
- Version 0.9.430 is the current Version on Client - PC's
- Version 0.9.488 only runs with Edge Chromium Dev
- Version 0.9.515 only runs with Edge Chromium Dev.

### Why is the microsoft.web.webview2 package not linked?
The packages are not linked because this does not allow the mapping of Any CPU.
The packages are always added only based on the setting of the projects.
The API calls in this project are designed to draw the correct DLL depending on CPU usage.
Therefore, the DLL's were included in the project.
The NATIVEN-DLL's can then be found in the bin directory under native/x86 or native/x64.


### Why are the sources in the projects only linked?
It may be that this is only temporary. 
Currently, the STD and CORE projects refer to the framework sources.
This has the advantage that the sources only have to be edited once and are kept the same.
V9515 has its own source code. The experimental interface was also integrated here. However, there is no wrapper for this.

### Name of the project files.
To enable quick switching between WebView2 versions, the namespaces are kept the same.
This is how it should be possible to do so later in the goal- project, simply on the basis of the 
package to decide which version of WebView2 to use.

- Diga.WebView2.Interop. {Framework}. {PakteVersion}
- Diga.WebView2.Wrapper. {Framework}. {PaketVersion}
- Diga.WebView2.WinForms. {Framework}. {PaketVersion}


### Framework:
- Std => Standard 2.1
- Core => Dotnet core 3.1
- no deposit => NET framework 4.7.2


### Why is there a difference between Std and Framework at all?
Because Microsoft has chosen to keep the Std version 2.1 out of the net framework, 
separation is absolutely necessary.
According to Microsoft, STD 2.0 is no longer supported.


### Package version:
This means the version of the WebView2 packages.

- V8355 => microsoft.web.webview2 0.8.355
- V9430 => microsoft.web.webview2 0.9.430
- V9488 => microsoft.web.webview2 0.9.488
- V9515 => microsoft.web.webview2 0.9.515-preview


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

### AddRemoteObject => COM interop
It is possible to pass a dot-net object as a remote object to the web browser. In my tests, I was able to set and read properties. However, I did not manage to call functions without errors. Neither with parameters, nor without and not with and without return. < V9430.
AddRemoteObject works fine when you use V9488. If you add the followin Rremote Object first:
```c#
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    public class HostObjectHelper
    {
        private const int DISP_E_MEMBERNOTFOUND = -2147352573;
        private const int DISP_E_TYPEMISMATCH = -2147352571;

        /// <summary>Check whether a member is a method of an object.</summary>
        /// <param name="obj">The host object to check.</param>
        /// <param name="name">The name of the member to check.</param>
        public bool IsMethod(object obj, string name)
        {
            Type type = obj.GetType();
            if (!type.IsClass || type.IsCOMObject)
                throw new COMException((string) null, -2147352571);
            if (type.GetMember(name).Length == 0)
                throw new COMException((string) null, -2147352573);
            foreach (MemberInfo memberInfo in type.GetMember(name))
            {
                if (memberInfo.MemberType == MemberTypes.Method)
                    return true;
            }
            return false;
        }
    }
```
It is important that the object is given the following name:
##### {60A417CA-F1AB-4307-801B-F96003F8938B} Host Object Helper

###### This text was automatically translated with the [Microsoft translator](https://www.bing.com/translator "Microsoft translator").





