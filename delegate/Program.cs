Calculate calculate = new Calculate(Sum);
var result = calculate(10, 20); // 30
Console.WriteLine(result);

var result2 = SumWith(30, 20, Sum); //50
Console.WriteLine(result2);

CalculateTax(); // 20

int Sum(int a, int b)
{
  return a + b;
}

int SumWith(int a, int b, Calculate calculate)
{
  return calculate(a, b);
}

void CalculateTax()
{
  var sum = delegate (List<int> values)
  {
    return values.Sum();
  };

  int result = sum(new List<int> { 2, 4, 6, 8 });
  Console.WriteLine(result);
}

delegate int Calculate(int x, int y);
