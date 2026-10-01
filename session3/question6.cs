using System;

class Account
{
    protected decimal Balance;

    public Account(decimal balance)
    {
        Balance = balance;
    }

    public virtual bool Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }
}

class SavingsAccount : Account
{
    public SavingsAccount(decimal balance)
        : base(balance)
    {
    }

    public override bool Withdraw(decimal amount)
    {
        // First reuse parent's check
        if (!base.Withdraw(amount))
        {
            return false;
        }

        // Check minimum balance
        if (Balance < 1000)
        {
            Balance += amount;
            return false;
        }

        return true;
    }

    public decimal GetBalance()
    {
        return Balance;
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount account = new SavingsAccount(5000);

        Console.WriteLine(
            "Withdrawing 2000 from savings with balance 5000");

        if (account.Withdraw(2000))
            Console.WriteLine(
                $"Success. Balance: {account.GetBalance()}");

        Console.WriteLine("Withdrawing 2500 more");

        if (!account.Withdraw(2500))
            Console.WriteLine(
                "Rejected: minimum balance is 1000");
    }
}