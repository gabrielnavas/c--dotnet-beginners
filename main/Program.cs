class Program
{

  // on cli: dotnet run hello world
  static void Main(string[] args)
  {
    if (args.Length > 0)
    {
      foreach (string arg in args)
      {
        Console.WriteLine(arg);
      }
    }
  }
}