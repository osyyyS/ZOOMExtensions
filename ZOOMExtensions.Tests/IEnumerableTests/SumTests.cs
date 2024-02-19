namespace ZOOMExtensions.Tests.IEnumerableTests;
public class SumTests
{
  [Fact]
  public void Sum_EmptyList_ReturnsZero()
  {
    var timeSpans = new List<TimeSpan>();
    var result = timeSpans.Sum();
    Assert.Equal(TimeSpan.Zero, result);
  }

  [Fact]
  public void Sum_SingleElement_ReturnsElement()
  {
    var timeSpans = new List<TimeSpan> { TimeSpan.FromMinutes(5) };
    var result = timeSpans.Sum();
    Assert.Equal(TimeSpan.FromMinutes(5), result);
  }

  [Fact]
  public void Sum_MultipleElements_ReturnsSum()
  {
    var timeSpans = new List<TimeSpan> { TimeSpan.FromMinutes(5), TimeSpan.FromMinutes(10), TimeSpan.FromMinutes(15) };
    var result = timeSpans.Sum();
    Assert.Equal(TimeSpan.FromMinutes(30), result);
  }
}
