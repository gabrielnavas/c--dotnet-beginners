string s = "Mary";
string s2 = s;
Console.WriteLine(s2); // Mary

int i = 5;
int j = i;
j = 50;
Console.WriteLine(j); // 50
Console.WriteLine(i); // 5


Car? bmw = new Car();
if (bmw is not null)
{
  bmw.Name = "bmw";
  Console.WriteLine(bmw); // reference to bmw type of Car
}

// printa 22 pois quantity esta null
int? quantity = 22;
if (quantity.HasValue)
{
  Console.WriteLine("Quantidade tem o valor " + quantity.GetValueOrDefault(55));
}

// printa 55 pois quantity esta null
quantity = null;
Console.WriteLine("Quantidade tem o valor " + quantity.GetValueOrDefault(55));

class Car
{
  public string Name;
}
