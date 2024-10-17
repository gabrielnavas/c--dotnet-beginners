// Action
Action<string> log = (string name) => Console.WriteLine(name);
log("Hello world"); // "Hello world"


// Func
Func<List<int>, int> calc = (List<int> values) => values.Sum();
int result = CalculateTax(calc, new List<int> { 2, 4, 6, 8 });
Console.WriteLine(result); // 20


int CalculateTax(Func<List<int>, int> callback, List<int> values)
{
  return callback(values);
}