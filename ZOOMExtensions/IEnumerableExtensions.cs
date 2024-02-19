namespace ZOOMExtensions;
public static class IEnumerableExtensions
{
  public static TimeSpan Sum(this IEnumerable<TimeSpan> timeSpans)
  {
    return timeSpans.Aggregate(TimeSpan.Zero, (subtotal, timeSpan) => subtotal + timeSpan);
  }
}
