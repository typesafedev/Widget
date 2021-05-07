using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Textbox : Widget, ITextbox
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

    public string Text
    {
      get;
      init;
    }

    public Textbox(int Width, int Height, string Text, int X, int Y) : base(X, Y)
    {
      this.Width = Width;
      this.Height = Height;
      this.Text = Text;
    }

    public override string Print() =>
      $"{nameof(Textbox)} {base.Print()} {nameof(Width)}={Width} {nameof(Height)}={Height} {nameof(Text)}=\"{Text}\"";
  }
}