namespace _06_OOP;

public class BankAccount
{
    public string Name;
    public string Password;

    public BankAccount(string loginData)
    {
        LoginData = loginData;
    }

    private int balance = 0;
    
    public void Deposit(int amount)
    {
        balance += amount;
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
        Console.WriteLine($"Your balance is: {balance:c}");
    }

    public bool Withdraw(int amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Not enough funds :(");
            Console.ReadKey();
            return false;
        }
        
        balance -= amount;
        return true;
    }
    public string LoginData { get; }
}   