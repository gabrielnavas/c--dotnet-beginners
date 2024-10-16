
try
{
  // erro de index
  string[] names = new string[] { };
  Console.WriteLine(names[0]);

  // erro de referencia nula
  string s = null;
  Console.WriteLine(s.Length);

  // erro qualquer
  throw new Exception();
}
catch (NullReferenceException ex)
{
  Console.WriteLine($"Erro de referência nula. {ex.Message}");
}
catch (IndexOutOfRangeException ex)
{
  Console.WriteLine($"Erro de indexamento nulo. {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Erro. {ex.Message}");
}
