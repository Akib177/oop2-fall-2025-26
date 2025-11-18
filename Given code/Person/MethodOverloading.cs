Account account = new Account("Alice");
Account accountWithDeposit = new Account("Bob", 1000.00m);

Console.WriteLine($"Account Owner: {account.Owner}, Balance: {account.Balance}");
Console.WriteLine($"Account Owner: {accountWithDeposit.Owner}, Balance: {accountWithDeposit.Balance}");

public class Account
{
    public decimal Balance { get; private set; }
    public string Owner { get; private set; }

    public Account(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public Account(string owner, decimal initialDeposit)
    {
        Owner = owner;
        Balance = initialDeposit;
    }
}