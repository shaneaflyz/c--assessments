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

    public void Rotate(double rotationDegree)
    {
      Center.Rotate(rotationDegree);
    }

    public void Move(double x, double y)
    {
      Center.Move(x, y);
    }

    public override string ToString()
    {
      return $"center: {Center}, radius: {Radius}";
    }
  }
}