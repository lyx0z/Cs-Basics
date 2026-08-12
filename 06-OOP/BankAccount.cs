namespace _06_OOP;

public class BankAccount
{
    private int balance = 0;

    static void ChooseOperation()
    {
        Console.WriteLine("Choose your Operation: "); 
        Console.WriteLine("deposit 1; withdraw 2; transfer 3. ");
        int operation = int.Parse(Console.ReadLine());
        if (operation == 1)
        {
            Console.WriteLine("Your balance is:", BankAccount.balance);
            Console.WriteLine("How much would you like to deposit?:");
            int deposit = int.Parse(Console.WriteLine());
            balance = balance + deposit;
            Console.WriteLine("Your new balance is:", balance);
        }
        

    }
}