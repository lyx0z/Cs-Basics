namespace _06_OOP;

public class UserTransferChoice
{
    public static void ChooseUserToTransfer(BankAccount loggedInAccount, BankAccount otherAccount1, BankAccount otherAccount2)
    {
        Console.WriteLine("Which user do you want to transfer money to?");
        Console.WriteLine("1. Chipmunk 2. Yasha");
        var moneyReceiver = int.Parse(Console.ReadLine());

        Console.WriteLine("How much money would you like to transfer?");
        var amount = int.Parse(Console.ReadLine());
        
        switch (moneyReceiver)
        {
            case 1:
            {
                if (loggedInAccount.Transfer(otherAccount1, amount))
                {
                    Console.WriteLine("Transfer successful!");
                }

                Console.ReadKey();
                break;
            }
            case 2:
            {
                if (loggedInAccount.Transfer(otherAccount2, amount))
                {
                    Console.WriteLine("Transfer successful!");
                }

                Console.ReadKey();
                break;
            }
            default:
                Console.WriteLine("Invalid option");
                break;
        }

    }
}