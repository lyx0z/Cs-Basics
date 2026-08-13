namespace Extra_Fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats your number?");
        int n = int.Parse(Console.ReadLine());
        int numberOfAttemps = 1;

        while (numberOfAttemps <= n)
        {
            if (numberOfAttemps % 3 == 0 && numberOfAttemps % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            
            else if(numberOfAttemps % 3 == 0)
            {
              Console.WriteLine("Fizz");
            }
            
            else if(numberOfAttemps % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(numberOfAttemps);
            }

            numberOfAttemps++;

        }

    }
}

