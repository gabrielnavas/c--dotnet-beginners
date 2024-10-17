int[] ages = { 2, 4, 7, 10, 29, 70 };

// first element
var firstElement = ages.First();
Console.WriteLine(firstElement); // 2

var whereElement = ages.Where(n => n > 10);
Console.WriteLine(string.Join(",", whereElement)); // 29, 70

var firstOrDefault = ages.FirstOrDefault(n => n > 500);
Console.WriteLine(firstOrDefault); // retorna 0 pq nao tem nenhum n maior que 500

var orderByDescending = ages.OrderByDescending(number => number);
Console.WriteLine(string.Join(",", orderByDescending)); // 70,29,10,7,4,2

var orderBy = ages.OrderBy(number => number);
Console.WriteLine(string.Join(",", orderBy)); // 2,4,7,10,29,70


var accounts = new List<BankAccount>{
  new BankAccount{Name = "João", Balance = 25, Branch="123"},
  new BankAccount{Name = "Maria", Balance = 99, Branch="123"},
  new BankAccount{Name = "Lucas", Balance = 55, Branch="1"},
  new BankAccount{Name = "Gabriel", Balance = 33, Branch="12"},
  new BankAccount{Name = "Miguel", Balance = 22, Branch="12"},
};

var groupByBranch = accounts.GroupBy(account => account.Branch);
foreach (var branch in groupByBranch)
{
  Console.WriteLine($"-- {branch.Key}"); // printa a branch
  foreach (var account in branch)
  {
    Console.WriteLine($"{account.Name}, {account.Balance}"); // printa cada item dessa branch
  }
}

var names = accounts.Select(account => account.Name);
Console.WriteLine(string.Join(",", names)); // João,Maria,Lucas,Gabriel,Miguel

//  LINQ com expressões lambda
var branchCustomers = accounts.Select(account => new BranchCustomer
{
  Name = account.Name,
  Branch = account.Balance
});
foreach (var item in branchCustomers)
{
  Console.WriteLine(item.Name);
}

class BranchCustomer
{
  public string Name { get; set; }
  public decimal Branch { get; set; }
}

class BankAccount
{
  public string Name { get; set; }
  public decimal Balance { get; set; }
  public string Branch { get; set; }
}