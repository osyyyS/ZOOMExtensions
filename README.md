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
