namespace SimpleGeometricFigures
{
  public class Point(double x, double y) : IGeometricFigure
  {
    public double X
    {
      get; set;
    } = x;

    public double Y
    {
      get; set;
    } = y;

    //  x' = x * cos(θ) - y * sin(θ)
    //  y' = x * sin(θ) + y * cos(θ)
    public void Rotate(double rotationDegree)
    {
      double rotationRadians = rotationDegree * (Math.PI / 180);
      X = X * Math.Cos(rotationRadians) - Y * Math.Sin(rotationRadians);
      Y = X * Math.Cos(rotationRadians) + Y * Math.Sin(rotationRadians);
    }

    public void Move(double x, double y)
    {
      X += x;
      Y += y;
    }

    public override string ToString()
    {
      return $"({X},{Y})";
    }
  }
}