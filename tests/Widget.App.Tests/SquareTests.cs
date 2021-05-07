using Xunit;
using FluentAssertions;
using System;
using Widget.App.Models;

namespace Widget.App.Tests
{
  public class SquareTests
  {
    [Theory]
    [InlineData(0, 0, 10, "Square (0, 0) Width=10")]
    [InlineData(0, 1, 20, "Square (0, 1) Width=20")]
    public void Prints_name_dimensions(int x, int y, int width, string expected)
    {
      var sut = new Square(width, x, y);

      var actual = sut.Print();

      actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_width_throws(int width)
    {
      Action act = () => new Square(width, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'Width must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_width_ok(int width)
    {
      Action act = () => new Square(width, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }
  }
}