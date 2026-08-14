namespace _06_OOP;

public class UserTransferChoice
{
    public static void ChooseUserToTransfer()
    {
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