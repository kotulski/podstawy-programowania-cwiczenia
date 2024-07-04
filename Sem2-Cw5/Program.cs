using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance = 0)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public string GetAccountNumber()
    {
        return accountNumber;
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Kwota wpłaty musi być większa niż zero.");
        }
        balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Kwota wypłaty musi być większa niż zero.");
        }
        if (amount > balance)
        {
            return false;
        }
        balance -= amount;
        return true;
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("49 1020 2892 2276 3005 0000 0000", 2000);

        Console.WriteLine($"Numer konta: {account.GetAccountNumber()}");

        Console.WriteLine($"Bieżące saldo: {account.GetBalance()}");

        account.Deposit(300);
        Console.WriteLine($"Saldo po wpłacie: {account.GetBalance()}");

        bool withdrawalSuccessful = account.Withdraw(570);
        Console.WriteLine(withdrawalSuccessful ? $"Saldo po wypłacie: {account.GetBalance()}" : "Niewystarczające saldo do wypłaty.");

        withdrawalSuccessful = account.Withdraw(2000);
        Console.WriteLine(withdrawalSuccessful ? $"Saldo po wypłacie: {account.GetBalance()}" : "Niewystarczające saldo do wypłaty.");
    }
}