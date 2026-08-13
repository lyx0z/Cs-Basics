namespace _06_OOP;

public class BankAccount
{
    public BankAccount(int startingBalance)
    {
        balance = startingBalance;
    }
    
    private int balance = 0;
    
    public void Deposit(int amount)
    {
        balance = balance + amount;
    }

    public bool Transfer(BankAccount destination, int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Not enough funds :(");
            return false;
        }

        balance -= amount;
        destination.Deposit(amount);

        return true;
    }
    
    public void ShowBalance()
    {
        Console.WriteLine($"Your balance is: {balance}");
    }

    public bool Withdraw(int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Not enough funds :(");
            Console.ReadKey();
            return false;
        }



        else
        {
            balance = balance - amount;
            return true;
        }

    }
}