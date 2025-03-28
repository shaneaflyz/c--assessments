namespace SimpleGeometricFigures
{
  public class Point(double x, double y)
  {
    public double X
    {
      get; set;
    } = x;

    public double Y
    {
      get; set;
    } = y;

    public override string ToString()
    {
      return $"({X},{Y})";
    }
  }
}