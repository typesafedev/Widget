using System;
using Widget.App.Interfaces;

// This service allows extension of operations on IWidget.
// Example demos addition of Area() on IWidget
namespace Widget.App.Services
{
  public class WidgetService : IWidgetService
  {
    public int? Area(IWidget widget) => widget switch
    {
      // Loss of precision
      ICircle circle =>
        (int)Math.PI * (circle.Diameter / 2) * (circle.Diameter / 2),
      // Loss of precision
      IEllipse ellipse =>
        (int)Math.PI * (ellipse.HorizontalDiameter / 2) * (ellipse.VerticalDiameter / 2),
      ITextbox textbox =>
        textbox.Width * textbox.Height,
      IRectangle rectangle =>
        rectangle.Height * rectangle.Width,
      ISquare square =>
        square.Width * square.Width,
      _ => null,
    };
  }
}