using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Ellipse : Widget, IEllipse
  {
    private readonly int horizontalDiameter;
    private readonly int verticalDiameter;
    public int HorizontalDiameter
    {
      get => horizontalDiameter;
      init => horizontalDiameter = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(horizontalDiameter)} must be positive") : value);
    }

    public int VerticalDiameter
    {
      get => verticalDiameter;
      init => verticalDiameter = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(VerticalDiameter)} must be positive") : value);
    }
    public Ellipse(int HorizontalDiameter, int VerticalDiameter, int X, int Y) : base(X, Y)
    {
      this.HorizontalDiameter = HorizontalDiameter;
      this.VerticalDiameter = VerticalDiameter;
    }

    public override string Print() =>
      $"{nameof(Ellipse)} {base.Print()} {nameof(HorizontalDiameter)}={HorizontalDiameter} {nameof(VerticalDiameter)}={VerticalDiameter}";
  }
}