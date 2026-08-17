namespace _06_OOP;

public static class AuthenticationService
{
    public static List<BankAccount> list = new List<BankAccount>();
    public static BankAccount activeAccount;
    public static void Register()
    {
        Console.WriteLine("What will be your Nickname?");
        var loginName = Console.ReadLine();
        Console.WriteLine("What will be your password?");
        var loginPassword = Console.ReadLine();
        var loginData = loginName + loginPassword;
        list.Add(new BankAccount(loginData));
    }
    
    public static void Login()
    {
        Console.WriteLine("What is you Log-in?");
        var loginName = Console.ReadLine();
        Console.WriteLine("What is your password");
        var loginPassword = Console.ReadLine();
        var loginData = loginName + loginPassword;
        foreach (var account in list)
        {
            if (account.LoginData == loginData)
            {
                activeAccount = account;
            }
        }
    }
    
    public static BankAccount GetActiveAccount()
    {
        return activeAccount;
    }
}

