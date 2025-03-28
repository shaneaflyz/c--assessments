namespace SimpleGeometricFigures
{
  public class Line(Point start, Point end)
  {

    public Point Start
    {
      get; set;
    } = start;

    public Point End
    {
      get; set;
    } = end;

    public override string ToString()
    {
      return $"start: {Start}, End: {End}";
    }
  }
}