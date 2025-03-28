static bool IsPalindrome(string inputString, string trashSymbols)
{
  IEnumerable<char> filtered = inputString
     .Where(c => !trashSymbols.Contains(c))  // Remove trash symbols
     .Select(char.ToLower);

  return filtered.SequenceEqual(filtered.Reverse());
}

Console.WriteLine(IsPalindrome("!!aacbb$aa", "$!"));