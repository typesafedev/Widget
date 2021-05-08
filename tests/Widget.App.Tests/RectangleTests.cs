using Xunit;
using FluentAssertions;
using System;
using Widget.App.Models;

namespace Widget.App.Tests
{
  public class RectangleTests
  {
    [Theory]
    [InlineData(0, 0, 10, 10, "Rectangle (0, 0) Width=10 Height=10")]
    [InlineData(0, 1, 20, 20, "Rectangle (0, 1) Width=20 Height=20")]
    public void Prints_name_dimensions(int x, int y, int width, int height, string expected)
    {
      var sut = new Rectangle(width, height, x, y);

      var actual = sut.ToString();

      actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_width_throws(int width)
    {
      Action act = () => new Rectangle(width, 0, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'Width must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_width_ok(int width)
    {
      Action act = () => new Rectangle(width, 0, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_height_throws(int height)
    {
      Action act = () => new Rectangle(0, height, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'Height must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_height_ok(int height)
    {
      Action act = () => new Rectangle(0, height, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }
  }
}