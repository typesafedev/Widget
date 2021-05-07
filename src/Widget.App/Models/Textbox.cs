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

    public Textbox(int Width, int Height, string Text, int X, int Y) : base(Width, Height, X, Y)
    {
      this.Width = Width;
      this.Height = Height;
      this.Text = Text;
    }

    public override string Print() =>
      $"{nameof(Textbox)} ({X}, {Y}) {nameof(Width)}={Width} {nameof(Height)}={Height} {nameof(Text)}=\"{Text}\"";
  }
}