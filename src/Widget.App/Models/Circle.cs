using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Circle : Widget, ICircle
  {
    private readonly int diameter;
    public int Diameter
    {
      get => diameter;
      init => diameter = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(Diameter)} must be positive") : value);
    }

    public Circle(int Diameter, int X, int Y) : base(X, Y)
    {
      this.Diameter = Diameter;
    }

    public override string Print() =>
      $"{nameof(Circle)} {base.Print()} Size={Diameter}";
  }
}