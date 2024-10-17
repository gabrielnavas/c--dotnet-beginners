// mais performático do que criar uma lista vazia.
// usando Enumerable ele não isntancia uma lista na memória
var test = Enumerable.Empty<int>();
foreach (var item in test)
{
  Console.WriteLine(item);
}

// gerar numeros
var range = Enumerable.Range(0, 5);
System.Console.WriteLine(string.Join(",", range)); // 0,1,2,3,4

// numeros aleatórios
var random = new Random();
var rangeRandom = Enumerable.Range(0, 5).Select(_ => random.Next(1, 100));
System.Console.WriteLine(string.Join(",", rangeRandom)); // 5 numeros aleatórios

// todas letras do alfabeto
var alfa = Enumerable.Range(0, 26).Select(number => (char)('a' + number));
System.Console.WriteLine(string.Join(",", alfa)); // a,b,c,d,e,f,g,h,i,j,k...