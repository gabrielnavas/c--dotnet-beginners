
try
{
  string s = null;
  Console.WriteLine(s.Length);
}
catch (NullReferenceException ex)
{
  Console.WriteLine($"Erro de referência nula. {ex.Message}");
}
