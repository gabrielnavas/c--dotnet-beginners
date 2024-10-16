

List<Person> persons = new List<Person>() {
new Person("Lett")
};

var p2 = new Person("John");
var p3 = new Person("Mary");

persons.Add(p2);
persons.Add(p3);
persons.Remove(p3);

foreach (Person p in persons)
{
  Console.WriteLine(p.Name);
}

DataStore<int> age = new();
age.Value = 55;
Console.WriteLine(age.Value); // 55


class DataStore<T>
{
  public T Value { get; set; }
}

class Person
{
  private string name;

  public Person(string name)
  {
    this.name = name;
  }

  public string Name
  {
    get { return name; }
  }
}