using System.Diagnostics;

namespace ZOOMExtensions.Tests.ProcessExtensionsTests;

public class GetProcessNameSafeTests
{
  [Fact]
  public void GetAllProcessNames()
  {
    try
    {
      foreach (var process in Process.GetProcesses())
      {
        process.GetMainModuleNameSafe();
      }
    }
    catch (System.ComponentModel.Win32Exception ex)
    {
      Assert.Fail(ex.Message);
    }
    catch (Exception)
    {

    }
  }
}
