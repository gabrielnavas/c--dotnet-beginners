using System.Text.Json;
using System.Text.Json.Serialization;

BankAccount bankAccount = new BankAccount(22);
string json = JsonSerializer.Serialize(bankAccount);
Console.WriteLine(json);

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

  [JsonConstructor]
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