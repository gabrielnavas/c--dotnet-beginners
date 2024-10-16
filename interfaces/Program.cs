

ILogger consoleLog = new ConsoleLogger("Welcome");
consoleLog.Log();

ILogger fileLog = new FileLogger("Welcome");
fileLog.Log();



interface ILogger
{
  void Log();
}

class ConsoleLogger : ILogger
{

  private string message;

  public ConsoleLogger(string message)
  {
    this.message = message;
  }

  public void Log()
  {
    Console.WriteLine(message);
  }
}


class FileLogger : ILogger
{

  private string message;

  public FileLogger(string message)
  {
    this.message = message;
  }

  public void Log()
  {
    File.AppendAllText("log.txt", $"{message}{Environment.NewLine}");
  }
}