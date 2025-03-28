
using SimpleGeometricFigures;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Point point = new(1.0,1.0);
      // Line line = new(point, point);
      Console.WriteLine(point.Rotate(90.0));
      Console.ReadLine();
    }
  }
}