namespace _06_OOP;

public class Menu
{
    public static void NameAsk(string name)
    {
        Console.WriteLine("Welcome Back, " + name);
    }

    public static void MenuOptions()
    {
        Console.WriteLine("              ===TerminalBank===");
        Console.WriteLine("1. My Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Transfer");
        Console.WriteLine("5. EXIT");
        Console.WriteLine("Choose your operation: ");
    }
}