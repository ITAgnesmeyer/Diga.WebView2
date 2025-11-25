# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade src\Diga.WebView2.Interop\Diga.WebView2.Interop.csproj
4. Upgrade src\Diga.WebView2.Wrapper\Diga.WebView2.Wrapper.csproj
5. Upgrade src\Diga.WebView2.Monitoring\Diga.WebView2.Monitoring.csproj
6. Upgrade src\Diga.WebView2.Scripting\Diga.WebView2.Scripting.csproj
7. Upgrade src\Diga.WebView2.Wpf\Diga.WebView2.Wpf.csproj
8. Upgrade src\Diga.WebView2.WinForms\Diga.WebView2.WinForms.csproj
9. Convert project style for src\Diga.WebView2.Native\Diga.WebView2.Native.vcxproj to SDK-style
10. Upgrade WebView2WrapperWpfTest\WebView2WrapperWpfTest.csproj
11. Upgrade WebView2WrapperWinFormsTest.Core\WebView2WrapperWinFormsTest.Core.csproj
12. Upgrade WebView2WrapperWinFormsTest\WebView2WrapperWinFormsTest.csproj

## Settings

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|



### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                        | Current Version | New Version | Description                                   |
|:------------------------------------|:---------------:|:-----------:|:----------------------------------------------|
| System.Data.DataSetExtensions       |    4.5.0        |             | Functionality now included in the framework reference, remove package |
| System.Drawing.Common               |    9.0.7        |  10.0.0     | Recommended upgrade for .NET 10.0             |
| System.Text.Json                    |    9.0.7        |  10.0.0     | Recommended upgrade for .NET 10.0             |


### Project upgrade details

#### src\Diga.WebView2.Interop\Diga.WebView2.Interop.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `netstandard2.0;netstandard2.1` to `netstandard2.0;netstandard2.1;net10.0`

NuGet packages changes:
  - No NuGet package changes discovered for this project.

Other changes:
  - None

#### src\Diga.WebView2.Wrapper\Diga.WebView2.Wrapper.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `netstandard2.0;netstandard2.1` to `netstandard2.0;netstandard2.1;net10.0`

NuGet packages changes:
  - No NuGet package changes discovered for this project.

Other changes:
  - Review usage of COM interop code for any new APIs or nullable behaviors on net10.0.

#### src\Diga.WebView2.Monitoring\Diga.WebView2.Monitoring.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `netstandard2.0;netstandard2.1` to `netstandard2.0;netstandard2.1;net10.0`

NuGet packages changes:
  - No NuGet package changes discovered for this project.

Other changes:
  - None

#### src\Diga.WebView2.Scripting\Diga.WebView2.Scripting.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `netstandard2.0;netstandard2.1` to `netstandard2.0;netstandard2.1;net10.0`

NuGet packages changes:
  - `System.Text.Json` should be updated from `9.0.7` to `10.0.0` (recommended replacement).

Other changes:
  - Verify API compatibility for System.Text.Json 10.0.0 and adjust call sites if breaking changes exist.

#### src\Diga.WebView2.Wpf\Diga.WebView2.Wpf.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net9.0-windows;net8.0-windows;net4.7.2` to `net9.0-windows;net8.0-windows;net4.7.2;net10.0-windows`

NuGet packages changes:
  - `System.Drawing.Common` should be updated from `9.0.7` to `10.0.0`.

Other changes:
  - Verify Windows-specific APIs compatibility for net10.0-windows.

#### src\Diga.WebView2.WinForms\Diga.WebView2.WinForms.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net4.7.2;net8.0-windows;net9.0-windows` to `net4.7.2;net8.0-windows;net9.0-windows;net10.0;net10.0--windows`

NuGet packages changes:
  - No NuGet package changes discovered for this project.

Other changes:
  - Confirm appropriate `UseWindowsForms` and Windows SDK settings for net10.0-windows target.

#### src\Diga.WebView2.Native\Diga.WebView2.Native.vcxproj modifications

Project properties changes:
  - Convert project to SDK-style if possible; review native project conversion guidance.

NuGet packages changes:
  - None

Other changes:
  - Native project conversion may require manual adjustments and cannot be converted automatically in some scenarios.

#### WebView2WrapperWpfTest\WebView2WrapperWpfTest.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net4.8;net8.0-windows;net9.0-windows` to `net4.8;net8.0-windows;net9.0-windows;net10.0-windows`

NuGet packages changes:
  - None

Other changes:
  - None

#### WebView2WrapperWinFormsTest.Core\WebView2WrapperWinFormsTest.Core.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net9.0-windows` to `net10.0-windows`

NuGet packages changes:
  - None

Other changes:
  - None

#### WebView2WrapperWinFormsTest\WebView2WrapperWinFormsTest.csproj modifications

Project properties changes:
  - Target frameworks should be changed from `net481` to `net10.0-windows`

NuGet packages changes:
  - `System.Text.Json` should be updated from `9.0.7` to `10.0.0`.
  - `System.Data.DataSetExtensions` (4.5.0) is included in the new framework reference and should be removed from package references.

Other changes:
  - Verify test project references and test runner compatibility on net10.0-windows.



