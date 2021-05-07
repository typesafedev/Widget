using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Widget(int X, int Y) : IWidget
  {
    public virtual string Print() => $"({X}, {Y})";
  }
}
