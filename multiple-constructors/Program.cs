BankAccount bankAccount = new BankAccount();
System.Console.WriteLine(bankAccount.Name); // anonymous
System.Console.WriteLine(bankAccount.Balance); // 0

class BankAccount
{
  private string name;
  private decimal balance;

  public string Name
  {
    get
    {
      return name;
    }
  }
  public decimal Balance
  {
    get
    {
      return balance;
    }
  }

  public BankAccount(string name, decimal balance)
  {
    this.name = name;
    this.balance = balance;
  }

  public BankAccount(decimal balance) : this("anonymous", balance)
  {
  }

  public BankAccount() : this("anonymous", 0)
  {
  }
}