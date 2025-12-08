# Diga.WebView2
WebView2 Wrapper For => [Edge Chromium](https://www.microsoft.com/edge "Edge Chromium")

Microsoft [WebView2](https://docs.microsoft.com/microsoft-edge/hosting/webview2 "WebView2")

### Nuget Packages:
There are NUGET-PACKAGES 

- Diga.WebView2.Interop => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Interop/ "NuGet")
- Diga.WebView2.Wrapper => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wrapper/ "NuGet")
- Diga.WebView2.WinForms => [NuGet](https://www.nuget.org/packages/Diga.WebView2.WinForms/ "NuGet")
- Diga.WebView2.Wpf => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Wpf/ "NuGet")
- Diga.WebView2.Scripting => [NuGet](https://www.nuget.org/packages/Diga.WebView2.Scripting/ "NuGet")

[WebView2 Runtime](https://developer.microsoft.com/en-us/microsoft-edge/webview2/)

## AOT
AOT has been moved to a separate project. Follow the link. [Diga.WebView.AOT](https://github.com/ITAgnesmeyer/Diga.WebView.AOT)

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
## Avalonia
To use the component in Avalonia (Windows only), you can create a custom class that inherits from NativeControlHost and override its methods as needed.
```c#
public class MyControl:NativeControlHost
{
...
   protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
   {
     
       IPlatformHandle platformHandle = base.CreateNativeControlCore(parent);
       // You can create a native control here and return its handle
       this._webView2Control = new Diga.WebView2.Wrapper.WebView2Control(platformHandle.Handle);
       this._webView2Control.Created += WebView2Control_Created;
       return platformHandle;
   }
   private void WebView2Control_Created(object? sender, EventArgs e)
   {
     _IsCreated = true;
     if (_webView2Control != null && _uri != null)
     {
         string urlString = _uri.ToString();
         if (!string.IsNullOrEmpty(urlString))
         {
             _webView2Control.Navigate(urlString);
         }
     }
   }
   protected override void OnSizeChanged(SizeChangedEventArgs e)
   {
      base.OnSizeChanged(e);
      if (_IsCreated)
      {
          Dispatcher.UIThread.Post(() =>
          {
              if (_webView2Control != null)
              {
                  // Ensure the WebView2 control is docked to the parent
                  _webView2Control.DockToParent();
              }
          });
          
      }
   
   }
   
...
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

### Check validity of the object
```c#
//sync
if(!this._DIV.VarExist())
   this._DIV = nothing;
...
// async
bool varExist = await this._DIV.VarExistAsync();
```
### Canvas
```c#

   //create Canvas
   DOMElement elem = this.WebView3.GetDOMDocument().createElement("canvas");
   this.WebView3.GetDOMDocument().body.appendChild(elem);

   DOMCanvasElement can = new DOMCanvasElement(elem);
   can.width = 200;
   can.height = 100;
   // Create Context
   var ctx = can.GetContext2D();
   //yellow rectangle
   ctx.fillStyle = "yellow";
   ctx.fillRect(0,0,255,255);
   //transform
   ctx.transform(1,(decimal)0.5, (decimal)-0.5,1,30,10);
   //blue rectangle
   ctx.fillStyle = "blue";
   ctx.fillRect(0,0,250,100);
   //reset Transform
   ctx.resetTransform();
   //draw line
   ctx.moveTo(0, 0);
   ctx.lineTo(200,100);
   ctx.stroke();

```






