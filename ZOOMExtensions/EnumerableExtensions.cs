using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZOOMExtensions;
public static class EnumerableExtensions
{
  public static TimeSpan Sum(this IEnumerable<TimeSpan> timespanList)
  {
    if (timespanList == null) throw new ArgumentNullException(nameof(timespanList));
    var timeSpanSum = TimeSpan.Zero;
    foreach (var timespan in timespanList)
    {
      timeSpanSum = timeSpanSum.Add(timespan);
    }
    return timeSpanSum;
  }
}
