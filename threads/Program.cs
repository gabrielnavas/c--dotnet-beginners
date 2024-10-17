Console.WriteLine("Executando");
Thread.Sleep(5000);
Console.WriteLine("Pronto");

Console.WriteLine("Executando Thread");
var task = Task.Run(() =>
{
  Thread.Sleep(5000);
  Console.WriteLine("Task executada");
});
if (task.IsCompleted)
{
  Console.WriteLine($"Já acabou");
}
Thread.Sleep(6000); // usada pra dar tempo de exibir o console writeline dentro da task
if (task.IsCompleted)
{
  Console.WriteLine($"Agora realmente acabou");
}

await Operacao();

async Task Operacao()
{
  Console.WriteLine("Começando de forma async");
  await Task.Run(() =>
  {
    Thread.Sleep(5000);
  });
  Console.WriteLine("Task executada de forma async");
}