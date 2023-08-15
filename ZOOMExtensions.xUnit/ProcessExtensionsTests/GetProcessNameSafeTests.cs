using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZOOMExtensions.xUnit.ProcessExtensionsTests
{
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
            catch (Exception ex) 
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
