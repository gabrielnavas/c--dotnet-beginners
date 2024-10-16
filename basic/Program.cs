// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool isOpen = true;
char letter = 'a';
byte number = 255;
int age = 22;
long foo = 8999999999999999999;
float pi = 3.14f;
double pii = 3.14159265359;
decimal price = 2.99m;
string name = "John";


// operations
if (isOpen)
{
  Console.WriteLine("Is Open!");
}

string ofLegalAge = age >= 18
  ? "I am of legal age"
  : "I'm not of legal age";
Console.WriteLine(ofLegalAge);

// methods
var nameUpperCase = "John".ToUpper();
Console.WriteLine(nameUpperCase);


// input name
Console.Write("Digite seu nome: ");
var inputedName = Console.ReadLine();
Console.WriteLine($"Olá, {inputedName}!");

// calculate age
Console.Write("Digite sua idade: ");
var inputedAge = Console.ReadLine();
Console.WriteLine($"Olá, {inputedName}, you are {inputedAge} years old!");
