namespace SimpleGeometricFigures
{
  public class Line(Point start, Point end) : IGeometricFigure
  {

    public Point Start
    {
      get; set;
    } = start;

    public Point End
    {
      get; set;
    } = end;

    public void Rotate(double rotationDegree)
    {
      Start.Rotate(rotationDegree);
      End.Rotate(rotationDegree);
    }

    public void Move(double x, double y)
    {
      Start.Move(x, y);
      End.Move(x, y);
    }

    public override string ToString()
    {
      return $"start: {Start}, End: {End}";
    }
  }
}