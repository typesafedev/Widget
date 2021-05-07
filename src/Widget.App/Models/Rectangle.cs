using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Rectangle : Widget, IRectangle
  {
    private readonly int width;
    private readonly int height;
    public int Width
    {
      get => width;
      init => width = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(Width)} must be positive") : value);
    }
    public int Height
    {
      get => height;
      init => height = (value < 0 ? throw new ArgumentOutOfRangeException($"{nameof(Height)} must be positive") : value);
    }

    public Rectangle(int Width, int Height, int X, int Y) : base(X, Y)
    {
      this.Width = Width;
      this.Height = Height;
    }

    public override string Print() =>
      $"{nameof(Rectangle)} {base.Print()} {nameof(Width)}={Width} {nameof(Height)}={Height}";
  }
}