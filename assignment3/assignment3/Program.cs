using System;

public class BankAccount
{
    // Properties
    public int AccNumber { get; }
    public decimal Bal { get; private set; }
    public string AccType { get; }

    // Constructors
    public BankAccount(int accNumber)
    {
        AccNumber = accNumber;
        Bal = 0;
        AccType = "Checking"; // Setting default account type as checking account.
    }

    public BankAccount(int accNumber, string accType) : this(accNumber)
    {
        AccType = accType;
    }

    // Methods
    public void Deposit(decimal amount)
    {
        Bal += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Bal:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Bal)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        Bal -= amount;
        Console.WriteLine($"Withdrawn {amount:C}. New balance: {Bal:C}");
    }

    // Overloaded Methods
    // Overloaded Deposit
    public void Deposit(decimal amount, string description)
    {
        Deposit(amount);
        Console.WriteLine($"Transaction description: {description}");
    }

    // Overloaded Withdraw
    public void Withdraw(decimal amount, string description)
    {
        Withdraw(amount);
        Console.WriteLine($"Transaction description: {description}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating different accounts using different constructors
        BankAccount checkingAcc = new BankAccount(123456);
        BankAccount savingAcc = new BankAccount(789012, "Saving");

        // Depositing and withdrawing from the accounts
        checkingAcc.Deposit(100);
        checkingAcc.Withdraw(50);

        savingAcc.Deposit(500);
        savingAcc.Withdraw(200);

        // Overloaded methods with transaction description
        checkingAcc.Deposit(200, "Bonus");
        savingAcc.Withdraw(100, "Emergency");
    }
}