namespace SimpleGeometricFigures
{
  public class Circle(Point center, double radius)
  {

    public Point Center
    {
      get; set;
    } = center;

    public double Radius
    {
      get; set;
    } = radius;

    public override string ToString()
    {
      return $"center: {Center}, radius: {Radius}";
    }
  }
}