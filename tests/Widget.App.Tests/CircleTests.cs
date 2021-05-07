using Xunit;
using FluentAssertions;
using System;
using Widget.App.Models;

namespace Widget.App.Tests
{
  public class CircleTests
  {
    [Theory]
    [InlineData(0, 0, 10, "Circle (0, 0) Size=10")]
    [InlineData(0, 1, 20, "Circle (0, 1) Size=20")]
    public void Prints_name_dimensions(int x, int y, int diameter, string expected)
    {
      var sut = new Circle(diameter, x, y);

      var actual = sut.Print();

      actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_width_throws(int diameter)
    {
      Action act = () => new Circle(diameter, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'Diameter must be positive')");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void Positive_diameter_ok(int diameter)
    {
      Action act = () => new Circle(diameter, 0, 0);

      act.Should().NotThrow<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void Negative_diameter_throws(int diameter)
    {
      Action act = () => new Circle(diameter, 0, 0);

      act.Should().Throw<ArgumentOutOfRangeException>()
        .WithMessage("Specified argument was out of the range of valid values. (Parameter 'Diameter must be positive')");
    }
  }
}