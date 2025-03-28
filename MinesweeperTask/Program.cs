// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

List<List<char>> grid = [
  ['x','0','x','x','x'],
  ['x','x','0','x','x'],
  ['x','x','0','x','x'],
  ['x','0','x','x','x'],
  ['0','x','x','x','x'],
];