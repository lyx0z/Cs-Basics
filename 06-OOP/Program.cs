using _06_OOP;

public class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;  
        bool running = true;
        
        // Console.WriteLine("Whats your name?");
        // var name = Console.ReadLine();
        var loggedInAccount = AuthenticationService.GetActiveAccount();
        while (running)
        {
            // Menu.NameAsk(name);
            Coin.CoinDraw();
            Menu.MenuOptions();

            int.TryParse(Console.ReadLine(), out var choice);
            switch (choice)
            {
                case 1:
                    loggedInAccount.ShowBalance();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("How much do you want to deposit? ");
                    int.TryParse(Console.ReadLine(), out var amount);

                    loggedInAccount.Deposit(amount);

                    Console.WriteLine("Deposit successful!");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("How much do you want to withdraw? ");
                    amount = int.Parse(Console.ReadLine());

                    if (loggedInAccount.Withdraw(amount))
                    {
                        Console.WriteLine("Withdrawal successful!");
                        Console.ReadKey();
                    }
                    break;
                // case 4:
                //     UserTransferChoice.ChooseUserToTransfer(loggedInAccount, otherAccount1, otherAccount2);
                //     break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.Clear();
        }

    }
}
