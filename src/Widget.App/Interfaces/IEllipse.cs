namespace Widget.App.Interfaces
{
  public interface IEllipse : IWidget
  {
    int HorizontalDiameter { get; init; }
    int VerticalDiameter { get; init; }
  }
}