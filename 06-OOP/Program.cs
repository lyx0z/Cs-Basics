using _06_OOP;

BankAccount loggedInAccount = new BankAccount(246);
var otherAccount1 = new BankAccount(319);
var otherAccount2 = new BankAccount(765);


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
        Console.WriteLine("Which user do you want to transfer money to?");
        Console.WriteLine("1. Chipmunk 2. Yasha");
        int moneyReceiver = int.Parse(Console.ReadLine());
        
        Console.WriteLine("How much money would you like to transfer?");
        int amount = int.Parse(Console.ReadLine());
        
        if (moneyReceiver == 1)
        {
            if (loggedInAccount.Transfer(otherAccount1, amount))
            {
                Console.WriteLine("Transfer successful!");
            }

            Console.ReadKey();
        }
        else if (moneyReceiver == 2)
        {
            if (loggedInAccount.Transfer(otherAccount2, amount))
            {
                Console.WriteLine("Transfer successful!");
            }

            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid option");
        }


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