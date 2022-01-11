using System.Runtime.InteropServices;

namespace Diga.WebView2.WinForms.Scripting
{
    [Guid("492AB1FF-FF27-4A23-93A8-540A4B9DAC37")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRpcObject
    {
        string id { get; set; }
        string objId { get; set; }
        string varname { get; set; }
        string action { get; set; }
        string param { get; set; }
        object item { get; set; }
        string idFullName { get; }
        string idName { get; }

        object Clone();
    }
}