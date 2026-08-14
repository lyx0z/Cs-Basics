using _06_OOP;

class Program
{
    static void Main(string[] args)
    {
        var loggedInAccount = new BankAccount(246);
        var otherAccount1 = new BankAccount(319);
        var otherAccount2 = new BankAccount(765);
        bool running = true;

        while (running)
        {
            var choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    loggedInAccount.ShowBalance();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("How much do you want to deposit? ");
                    int amount = int.Parse(Console.ReadLine());

                    loggedInAccount.Deposit(amount);

                    Console.WriteLine("Deposit successful!");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("How much do you want to withdraw? ");
                    var amount = int.Parse(Console.ReadLine());

                    if (loggedInAccount.Withdraw(amount))
                    {
                        Console.WriteLine("Withdrawal successful!");
                        Console.ReadKey();
                    }
                    break;
                case 4:
                    Console.WriteLine("Which user do you want to transfer money to?");
                    Console.WriteLine("1. Chipmunk 2. Yasha");
                    var moneyReceiver = int.Parse(Console.ReadLine());

                    Console.WriteLine("How much money would you like to transfer?");
                    var amount = int.Parse(Console.ReadLine());

                    UserTransferChoice.ChooseUserToTransfer();
                
                
            }
            
            
            Console.Clear();
        }

    }
}
