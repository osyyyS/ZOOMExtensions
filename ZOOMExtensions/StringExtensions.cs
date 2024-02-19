using System.Text.RegularExpressions;

namespace ZOOMExtensions;

public static partial class StringExtensions
{
  [GeneratedRegex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$")]
  private static partial Regex EmailRegex();

  public static bool IsValidEmail(this string? email)
  {
    if (string.IsNullOrEmpty(email))
      return false;
    Regex regex = EmailRegex();
    return regex.IsMatch(email);
  }
}
