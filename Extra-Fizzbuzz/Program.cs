// namespace Extra_Fizzbuzz;
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Whats your number?");
//         int n = int.Parse(Console.ReadLine());
//         int counter = 1;
//
//         while (counter <= n)
//         {
//             if (counter % 3 == 0 && counter % 5 == 0)
//             {
//                 Console.WriteLine("Fizzbuzz");
//             }
//             
//             else if(counter % 3 == 0)
//             {
//               Console.WriteLine("Fizz");
//             }
//             
//             else if(counter % 5 == 0)
//             {
//                 Console.WriteLine("Buzz");
//             }
//
//             else
//             {
//                 Console.WriteLine(counter);
//             }
//
//             counter++;
//
//         }
//
//     }
// } 
//

namespace Extra_Fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats your number?");
        var n = int.Parse(Console.ReadLine());
        var counter = 1;
        
        while (counter <= n)
        {
            var smth = "";
            
            if (counter % 3 == 0 )
            {
                smth += "Fizz";
            }

            if (counter % 5 == 0)
            {
                smth += "Buzz";
            }
            
            if (smth == "")
            {
                var numberAsText = counter.ToString();
                smth += numberAsText;
            }
            
            Console.WriteLine(smth);
            counter++;
            
        }
    }
} 


