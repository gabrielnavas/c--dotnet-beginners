
try
{
  string[] names = new string[] { };
  Console.WriteLine(names[0]);

  string s = null;
  Console.WriteLine(s.Length);
}
catch (NullReferenceException ex)
{
  Console.WriteLine($"Erro de referência nula. {ex.Message}");
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine($"Erro de indexamento nulo. {ex.Message}");
}
