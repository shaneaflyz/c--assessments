namespace SimpleGeometricFigures
{
  class Aggregation(List<IGeometricFigure> figures) : IGeometricFigure
  {
    public List<IGeometricFigure> Figures
    {
      get; set;
    } = figures;


    public void Rotate(double rotationDegree)
    {
      if (Figures.Count > 0)
        foreach (IGeometricFigure figure in Figures)
          figure.Rotate(rotationDegree);
      else
        Console.WriteLine("Figures empty");
    }

    public void Move(double x, double y)
    {
      if (Figures.Count > 0)
        foreach (IGeometricFigure figure in Figures)
          figure.Move(x, y);
      else
        Console.WriteLine("Figures empty");
    }

    public override String ToString() {
      if (Figures.Count == 0)
        return "Figures Empty";
        
      foreach (IGeometricFigure figure in Figures)
        return string.Join("\n", Figures.Select(f => f.ToString()));

      return "";
    }
  }
}