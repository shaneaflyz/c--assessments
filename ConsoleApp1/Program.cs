
using SimpleGeometricFigures;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Point point = new(2.4,3.6);
      Line line = new(point, point);
      Console.WriteLine(line.ToString());
      Console.ReadLine();
    }
  }
}