using _06_OOP;

BankAccount account = new BankAccount();

bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine("TerminalBANK");
    Console.WriteLine("1. Show balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
    Console.Write("Choose an option: ");

    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        account.ShowBalance();
        Console.ReadKey();
    }
    else if (choice == 2)
    {
        Console.Write("How much do you want to deposit? ");
        int amount = int.Parse(Console.ReadLine());

        account.Deposit(amount);

        Console.WriteLine("Deposit successful!");
        Console.ReadKey();
    }
    
    else if (choice == 3)
    {
        Console.Write("How much do you want to withdraw? ");
        int amount = int.Parse(Console.ReadLine());
        
        if (account.Withdraw(amount))
        {
            Console.WriteLine("Withdrawal successful!");
            Console.ReadKey();
        }
    }

    else if (choice == 4)
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
    
}