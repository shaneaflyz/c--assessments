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

    //  x' = x * cos(θ) - y * sin(θ)
    //  y' = x * sin(θ) + y * cos(θ)
    public Point Rotate(double rotationDegree) {
      double rotationRadians = rotationDegree * (Math.PI/180);
      Point rotatedPoint = new(0, 0)
      {
        X = X * Math.Cos(rotationRadians) - Y * Math.Sin(rotationRadians),
        Y = X * Math.Cos(rotationRadians) + Y * Math.Sin(rotationRadians)
      };

      return rotatedPoint;
    }

    public override string ToString()
    {
      return $"({X},{Y})";
    }
  }
}