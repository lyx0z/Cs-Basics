using _06_OOP;

BankAccount loggedInAccount = new BankAccount();
var otherAccount = new BankAccount();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("TerminalBANK");
    Console.WriteLine("1. Show balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Transfer");
    Console.WriteLine("5. EXIT");
    Console.Write("Choose an option: ");
    
    var choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        loggedInAccount.ShowBalance();
        Console.ReadKey();
    }
    else if (choice == 2)
    {
        Console.Write("How much do you want to deposit? ");
        int amount = int.Parse(Console.ReadLine());

        loggedInAccount.Deposit(amount);

        Console.WriteLine("Deposit successful!");
        Console.ReadKey();
    }
    
    else if (choice == 3)
    {
        Console.Write("How much do you want to withdraw? ");
        int amount = int.Parse(Console.ReadLine());
        
        if (loggedInAccount.Withdraw(amount))
        {
            Console.WriteLine("Withdrawal successful!");
            Console.ReadKey();
        }
    }

    else if (choice == 4)
    {
        Console.Write("How much do you want to transfer to user @Chipmunk?: ");
        int amount = int.Parse(Console.ReadLine());

        if (loggedInAccount.Transfer(otherAccount, amount))
        {
            Console.WriteLine("Transfer successful!");
        }

        Console.ReadKey();
        
    }
    else if (choice == 5)
    {
        running = false;
        Console.WriteLine("Goodbye!");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Invalid option.");
        Console.ReadKey();
    }
    Console.Clear();
    
}