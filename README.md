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

### packages are currently supported.
microsoft.web.webview2

- Version 1.0.1108.44 is the current Version on Client - PC's

WebView2 [Release-Notes](https://docs.microsoft.com/de-de/microsoft-edge/webview2/releasenotes)

### Why is the microsoft.web.webview2 package not linked in Package?
Native calls are made via a separate C++ DLL. 
The package from Microsoft is then also linked here. 
The native DLL links the WebView2LoaderStatic.lib. 
Therefore, a link to the Microsoft.Web.WebView2 package is no longer necessary in the package.



### Package version:
This means the version of the WebView2 packages.
- V10107254 => [microsoft.web.webview2 1.0.1108.44](https://www.nuget.org/packages/Microsoft.Web.WebView2/1.0.1108.44)

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
The Windows Forms and WPF project now supports DOM objects.
You can retrieve the DOM - Window object and the DOM - Document object directly by using the GetDOMWidow() and GetDOMDocument() functions.
Events are only add sync functions!!
```c#
DOMElement button = this.WebView3.GetDOMDocument().getElementById("ga_button");
button.Click += (o, ev) =>
{
   MessageBox.Show("Test from Button");
};
```


The following code will throw an exception!!

```c#
DOMElement button = this.WebView3.GetDOMDocument().getElementById("ga_button");

// you cannot add async Eventhandler!!!
// this will Raise InvalidOperation!!
button.Click += async (o, ev) =>
{
   await this.WebView3.GetDOMWindow().alertAsync("TEST");
};

```
Asynchronous and synchronous calls should never be mixed. 
If possible, use the synchronous calls.

### Correct example
```c#
    DOMDocument doc = this.webView1.GetDOMDocument();
    this._DIV = doc.createElement("div");
    this._DIV.id = Guid.NewGuid().ToString();
    doc.body.appendChild(this._DIV);
    //add a button element
    DOMElement element = doc.createElement("button");
    //set inner html of button 
    element.innerHTML = "Click Me";
    //set id of Button-Element
    element.id = Guid.NewGuid().ToString();

    //add Button to DIV
    this._DIV.appendChild(element);

    //Add EventHandler
    // Important never call synchron Properties and Functions in an async function
    element.Click += OnDomElementClick1;
    element.Click += OnDomElementClick;
    ...
    private void OnDomElementClick1(object sender, DOMMouseEventArgs e)
    {
      ...
    }
    private void OnDomElementClick(object sender, DOMMouseEventArgs e)
    {
      ...
    }
    
```
Note that as soon as a new document is created, the old variables become invalid. 
You can query the validity of the variable with VarExist().
Use thie WebView-Event DOMContentLoaded to cleanup.

### Check validity of the object
```c#
//sync
if(!this._DIV.VarExist())
   this._DIV = nothing;
...
// async
bool varExist = await this._DIV.VarExistAsync();
```


###### This text was automatically translated with the [Microsoft translator](https://www.bing.com/translator "Microsoft translator").





