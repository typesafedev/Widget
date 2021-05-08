using System.IO;
using System.Threading.Tasks;

namespace Widget.App.Interfaces
{
  public interface IWidget
  {
    int X { get; init; }
    int Y { get; init; }
    
    Task Print(TextWriter tw);
  }
}