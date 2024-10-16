

ILogger log = new Logger("Welcome");
log.Log();


interface ILogger
{
  void Log();
}

class Logger : ILogger
{

  private string message;

  public Logger(string message)
  {
    this.message = message;
  }

  public void Log()
  {
    Console.WriteLine(message);
  }
}