using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ZOOMExtensions;

public static partial class ProcessExtensions
{
  [LibraryImport("kernel32.dll")]
  private static partial IntPtr OpenProcess(uint processAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int processId);

  [DllImport("psapi.dll", CharSet = CharSet.Unicode)]
  private static extern uint GetModuleFileNameEx(IntPtr hProcess, IntPtr hModule, [Out] StringBuilder lpBaseName, [In][MarshalAs(UnmanagedType.U4)] int nSize);

  [LibraryImport("kernel32.dll", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static partial bool CloseHandle(IntPtr hObject);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static string? GetMainModuleNameSafe(this Process process)
  {
    var processHandle = OpenProcess(0x0400 | 0x0010, false, process.Id);

    if (processHandle == IntPtr.Zero)
    {
      return null;
    }

    const int lengthSb = 4000;

    var sb = new StringBuilder(lengthSb);

    string? result = null;

    if (GetModuleFileNameEx(processHandle, IntPtr.Zero, sb, lengthSb) > 0)
    {
      result = Path.GetFileName(sb.ToString());
    }

    CloseHandle(processHandle);

    return result;
  }
}
