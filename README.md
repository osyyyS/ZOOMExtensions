# ZOOMExtensions
 .NET 7 C# Extensions

 ## Install

- 📦 [NuGet](https://www.nuget.org/packages/ZOOMExtensions): `dotnet add package ZOOMExtensions`

## Usage

### Strings

#### Checking if string is a valid **e-mail address**

To check if a string is a valid e-mail address, call `.IsValidEmail()`:

```csharp
using ZOOMExtensions;

string email = "asd@cooldomain.com";

bool isEmail = email.IsValidEmail();
```

### Processes

#### Receiving **MainModuleName** from Process

To receive process.MainModule.ModuleName without running into a System.ComponentModel.Win32Exception, call `.GetMainModuleNameSafe()`:

```csharp
using ZOOMExtensions;

var process = Process.GetCurrentProcess();

string? mainModuleName = process.GetMainModuleNameSafe();
```
