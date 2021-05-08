using Xunit;
using FluentAssertions;
using System;
using Widget.App.Models;

namespace Widget.App.Tests
{
  public class EllipseTests
  {
    [Theory]
    [InlineData(0, 0, 10, 10, "Ellipse (0, 0) HorizontalDiameter=10 VerticalDiameter=10")]
    [InlineData(0, 1, 20, 20, "Ellipse (0, 1) HorizontalDiameter=20 VerticalDiameter=20")]
    public void Prints_dimensions(int x, int y, int horizontalDiameter, int verticalDiameter, string expected)
    {
      var sut = new Ellipse(horizontalDiameter, verticalDiameter, x, y);

      var actual = sut.ToString();

      actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_horizontalDiameter_throws(int horizontalDiameter)
    {
      Action act = () => new Ellipse(horizontalDiameter, 0, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'HorizontalDiameter must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_horizontalDiameter_ok(int horizontalDiameter)
    {
      Action act = () => new Rectangle(horizontalDiameter, 0, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_verticalDiameter_throws(int verticalDiameter)
    {
      Action act = () => new Ellipse(0, verticalDiameter, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'VerticalDiameter must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_verticalDiameter_ok(int verticalDiameter)
    {
      Action act = () => new Ellipse(0, verticalDiameter, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }
  }
}