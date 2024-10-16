// Action
Action<string> log = delegate (string name) {
  Console.WriteLine(name);
};
log("Hello world"); // "Hello world"


// Func
int result = CalculateTax(calc, new List<int> { 2, 4, 6, 8 });
Console.WriteLine(result); // 20

int calc(List<int> values)
{
  return values.Sum();
}

int CalculateTax(Func<List<int>, int> callback, List<int> values)
{
  return callback(values);
}