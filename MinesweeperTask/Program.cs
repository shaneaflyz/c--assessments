
/*
  given that (r,c) = (1,1)
  
  adjacent grid:
  go up -> (r-1, c)
  go down -> (r+1, c)
  go left -> (r, c-1)
  go right -> (r, c+1)

  diagonal grid:
  go up,left -> (r-1, c-1)
  go up,right -> (r-1, c+1)
  go down,left -> (r+1, c-1)
  go down,right -> (r+1, c+1)
*/
class Minesweeper
{
  static readonly int[,] grid =
  {
    { 0, 0, 0, 0, 1 },
    { 0, 1, 0, 1, 0 },
    { 0, 0, 0, 0, 0 },
    { 1, 0, 1, 0, 0 },
    { 0, 0, 0, 1, 0 }
  };

  private static readonly int rows = 5;
  private static readonly int cols = 5;
  static (int, int) start = (0, 0);
  static (int, int) goal = (4, 4);
  static readonly int[,] directions = {
    { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 }, // up, down, left, right
    { -1, -1 }, { -1, 1 }, { 1, -1 }, { 1, 1 } // up left, up right, down left, down right
  };

// use breadth first search algorithm to search through the shortest path to safety
  static int BFS()
  {
    Queue<((int, int), int)> queue = new();
    HashSet<(int, int)> visited = [];

    queue.Enqueue((start, 0));
    visited.Add(start);

    while (queue.Count > 0)
    {
      var ((x, y), dist) = queue.Dequeue();
      if ((x, y) == goal) return dist;

      for (int i = 0; i < directions.GetLength(0); i++)
      {
        int nx = x + directions[i, 0];
        int ny = y + directions[i, 1];
        if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0 && !visited.Contains((nx, ny)))
        {
          queue.Enqueue(((nx, ny), dist + 1));
          visited.Add((nx, ny));
        }
      }
    }
    return -1; // No path found
  }

  static void Main()
  {
    int result = BFS();
    Console.WriteLine(result == -1 ? "No path to safety!" : $"Shortest path length: {result}");
  }
}
