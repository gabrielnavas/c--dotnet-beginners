string name = "John";
string name2 = "john";

if (string.Equals(name, name2, StringComparison.OrdinalIgnoreCase))
{
  Console.WriteLine("São iguais");
}

var sameName = name == name2;
if (sameName)
{
  Console.WriteLine("São iguais");
}
else
{
  Console.WriteLine("Não são iguais");
}

bool hasJ = name.Contains("j", StringComparison.CurrentCultureIgnoreCase);
if (hasJ)
{
  Console.WriteLine("Tem j");
}

bool endsN = name.EndsWith("n");
if (endsN)
{
  Console.WriteLine("Termina com N");
}

int indexOfStart = "I like cars".IndexOf("like");
Console.WriteLine("like index starts in index " + indexOfStart);

// null, empty or spaces in string
string nameNull = null;
bool isNameNull = string.IsNullOrEmpty(nameNull);
Console.WriteLine("Name is null or empty? " + isNameNull);
nameNull = "";
isNameNull = string.IsNullOrEmpty(nameNull);
Console.WriteLine("Name is null or empty? " + isNameNull);
nameNull = "Hello";
isNameNull = string.IsNullOrEmpty(nameNull);
Console.WriteLine("Name is null or empty? " + isNameNull);

nameNull = "                   ";
isNameNull = string.IsNullOrWhiteSpace(nameNull);
Console.WriteLine("Name is null or white spaces? " + isNameNull);

// join string
string[] words = { "I like", "apples" };
string phrase = string.Join(" ", words);
Console.WriteLine(phrase);

// int to string
int age = 22;
string ageStr = age.ToString();
Console.WriteLine(ageStr);

// try parse
string year = "2024";
if (int.TryParse(year, out int result))
{
  Console.WriteLine(result);
}
else
{
  System.Console.WriteLine("Não foi possível converter");
}