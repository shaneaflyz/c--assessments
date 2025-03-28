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

    public Line Rotate(double rotationDegree) {
      Line rotatedLine =  new(Start, End);
      rotatedLine.Start = rotatedLine.Start.Rotate(rotationDegree);
      rotatedLine.End = rotatedLine.End.Rotate(rotationDegree);

      return rotatedLine;
    }

    public override string ToString()
    {
      return $"start: {Start}, End: {End}";
    }
  }
}