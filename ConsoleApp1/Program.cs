namespace SimpleGeometricFigures
{
  class Program
  {
    static void Main(string[] args)
    {
      Point start = new(1.0,1.0);
      Circle circle = new(start, 10);
      Point end = new(2.0,2.0);
      Line line = new(start, end);
      List<IGeometricFigure> figures = [start,end,line,circle];
      Aggregation aggregation = new(figures);
      aggregation.Move(1,1);
      // line.Rotate(90);
      Console.WriteLine(aggregation);
      Console.ReadLine();
    }
  }
}