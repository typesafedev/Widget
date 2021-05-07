namespace Widget.App.Interfaces
{
  public interface IWidget
  {
    int X { get; init; }
    int Y { get; init; }

    string Print();
  }
}