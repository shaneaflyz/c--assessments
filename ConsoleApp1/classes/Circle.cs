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

    public Circle Rotate(double rotationDegree)
    {
      Circle rotatedCircle = new(Center, Radius);
      rotatedCircle.Center = rotatedCircle.Center.Rotate(rotationDegree);

      return rotatedCircle;
    }

    public void Move(double x, double y)
    {
      Center.Move(x,y);
    }

    public override string ToString()
    {
      return $"center: {Center}, radius: {Radius}";
    }
  }
}