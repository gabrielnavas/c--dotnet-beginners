BankAccount account = new BankAccount("Jonny", 50.50m);
account.Deposit(100.50m);

Console.WriteLine(account.Balance);

class BankAccount
{
  private string name;
  private decimal balance;

  public string Name
  {
    get { return name; }
    set
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentException("Nome inválido.", nameof(name));
      }
    }
  }

  public decimal Balance
  {
    get { return balance; }
    private set
    {
      if (value < 0)
      {
        throw new ArgumentException("Balanço inválido.", nameof(balance));
      }
      balance = value;
    }
  }

  public BankAccount(string name, decimal balance)
  {
    Name = name;
    Balance = balance;
  }

  public void Deposit(decimal amount)
  {
    Balance += amount;
  }
}