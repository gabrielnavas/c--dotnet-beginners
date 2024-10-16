BankAccount account = new BankAccount("Jonny", 50.50m);
account.Deposit(100);

System.Console.WriteLine(account.GetBalance());

class BankAccount
{
  private string name;
  private decimal balance;

  public BankAccount(string name, decimal balance)
  {

    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Nome inválido.", nameof(name));
    }
    if (balance < 0)
    {
      throw new ArgumentException("Balanço inválido.", nameof(balance));
    }
    this.balance = balance;
    this.name = name;
  }

  public void Deposit(decimal amount)
  {
    if (balance < 0)
    {
      throw new ArgumentException("Balanço inválido.", nameof(balance));
    }

    balance += amount;
  }

  public decimal GetBalance() {
    return balance;
  }
}