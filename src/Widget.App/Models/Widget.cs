using System.IO;
using System.Threading.Tasks;
using Widget.App.Interfaces;

namespace Widget.App.Models
{
  public record Widget(int X, int Y) : IWidget
  {
    public override string ToString() => $"({X}, {Y})";

    public virtual async Task Print(TextWriter tw) => 
      await tw.WriteLineAsync(ToString()); 
  }
}
