namespace _06_OOP;

public class BankAccount
{
    private int balance = 0;
    public void Deposit(int amount)
    {
        balance = balance + amount;
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