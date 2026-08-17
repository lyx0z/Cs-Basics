namespace _06_OOP;

public class Menu
{
    // public static void AskForCredentials()
    // {
    //     Console.WriteLine("Enter your credentials");
    //     Console.WriteLine("What is you Log-in?");
    //     var loginName = Console.ReadLine();
    //     AuthenticationService.Login();
    // }
    
    public void LogOptions()
    {
        Console.WriteLine("Choose your option");
        Console.WriteLine("1. Register");
        Console.WriteLine("2. Log in");
        int.TryParse(Console.ReadLine(), out var logOption);
        if (logOption == 1)
        {
            AuthenticationService.Register();
        }
        else if (logOption == 2)
        {
            AuthenticationService.Login();
        }
    }

    public static void AskCredentials(string name, string password)
    {
        
        Console.WriteLine("Welcome Back, " + AuthenticationService.activeAccount.LoginData);
    }

    public static void MenuOptions()
    {
        Console.WriteLine("             ===TerminalBank===");
        Console.WriteLine("1. My Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Transfer");
        Console.WriteLine("5. EXIT");
        Console.WriteLine("Choose your operation: ");
    }
}