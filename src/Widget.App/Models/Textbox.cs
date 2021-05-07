using System;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Textbox : Rectangle, ITextbox
  {
    public string Text
    {
      get;
      init;
    }

    public Textbox(int Width, int Height, string Text, int X, int Y) : base(X, Y, Width, Height)
    {
      this.Width = Width;
      this.Height = Height;
      this.Text = Text;
    }

    public override string Print() =>
      $"{nameof(Textbox)} {base.Print()} {nameof(Width)}={Width} {nameof(Height)}={Height} {nameof(Text)}=\"{Text}\"";
  }
}