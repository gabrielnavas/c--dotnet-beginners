string s = "Mary";
string s2 = s;
Console.WriteLine(s2); // Mary


int i = 5;
int j = i;
j = 50;
Console.WriteLine(j); // 50
Console.WriteLine(i); // 5


Car bmw = new Car();
bmw.Name = "bmw";

Console.WriteLine(bmw); // reference to bmw type of Car

class Car {
 public string Name;
}
