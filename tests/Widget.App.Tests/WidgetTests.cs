using Xunit;
using FluentAssertions;

namespace Widget.App.Tests
{
  public class WidgetTests
  {
    [Theory]
    [InlineData(0, 0, "(0, 0)")]
    [InlineData(0, 1, "(0, 1)")]
    [InlineData(1, 0, "(1, 0)")]
    public void Prints_X_Y(int x, int y, string expected)
    {
      var sut = new Widget.App.Models.Widget(x, y);

      var actual = sut.Print();

      actual.Should().Be(expected);
    }
  }
}
