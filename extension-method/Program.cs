"Hello World".Write(ConsoleColor.DarkBlue);

static class ConsoleLine {
  public static void Write(this string text, ConsoleColor color)
  {
    Console.ForegroundColor = color;
    Console.WriteLine(text);
    Console.ResetColor();
  }
}
