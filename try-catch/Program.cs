
try
{
  string s = null;
  Console.WriteLine(s.Length);
}
catch (NullReferenceException)
{
  Console.WriteLine("Erro de referência nula.");
}
