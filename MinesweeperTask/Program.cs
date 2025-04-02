
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

  // 1 is bomb
  // 0 is safe space
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
    // stores ((x, y), distance)
    Queue<((int, int), int)> queue = new(); 
    HashSet<(int, int)> visited = [];

    queue.Enqueue((start, 0));
    visited.Add(start);

    while (queue.Count > 0)
    {
      // get current position and distance
      var (pos, dist) = queue.Dequeue(); 
      int x = pos.Item1, y = pos.Item2;

      // if we reached goal, return the distance
      if (pos == goal) return dist; 

      for (int i = 0; i < directions.GetLength(0); i++)
      {
        // change in row
        int newX = x + directions[i, 0];

        //change in column
        int newY = y + directions[i, 1];

        bool isValidIndex = newX >= 0 && newY >= 0 && newX < rows && newY < cols;
        bool isPathSafe = isValidIndex && grid[newX, newY] == 0;
        bool isPathUnvisited = isValidIndex && !visited.Contains((newX, newY));

        if (isPathSafe && isPathUnvisited)
        {
          queue.Enqueue(((newX, newY), dist + 1));
          visited.Add((newX, newY));
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
