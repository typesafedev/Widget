using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Square : Widget, ISquare
  {
    private readonly int width;
    public int Width
    {
      get => width;
      init => width = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(Width)} must be positive") : value);
    }

    public Square(int Width, int X, int Y) : base(X, Y)
    {
      this.Width = Width;
    }

    public override string Print() =>
      $"{nameof(Square)} {base.Print()} {nameof(Width)}={Width}";
  }
}