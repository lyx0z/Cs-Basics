namespace  Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreibe ein Programm, dass zwei Zahlen als Input erwartet. Das Programm soll jeweils ausgeben, ob die beiden Zahlen gleich sind oder nicht. Benutze dafür die keywords if / else.
            //Erweitere das Programm so, dass dies nun auch ausgeben soll, ob die beiden Inputs ein Vielfaches voneinander sind.
            Console.WriteLine("What is your first number?");
            var firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var secondNumber = int.Parse(Console.ReadLine());

            if ((firstNumber == 0)||(secondNumber == 00))
            {
                Console.WriteLine("Cant use 0");
                return;
            }
            
            if(firstNumber == secondNumber)
            {
                Console.WriteLine("Your numbers are a multiple of each other");
                Console.WriteLine("Your numbers are equal");
            }
            else if(firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
            {
                Console.WriteLine("your numbers are not equals");
                Console.WriteLine("Your numbers are a multiple of each other");
            }

            else
            {
                Console.WriteLine("Your numbers are not equal");
                Console.WriteLine("Your numbers are not a multiple of each other");
            }
            
            
            // Schreibe ein Programm, dass eine Zahl für eine Farbauswahl als Benutzereingabe entegennimmt. 1 = rot, 2= blau, 3 = grün, 4 = gelb. Bei allen anderne Eingaben soll eine Fehlermeldung 
            
            Console.WriteLine("wähle dein Zahl 1-4: ");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("rot");
                        break;
                    case 2:
                        Console.WriteLine("blau");
                        break;
                    case 3:
                        Console.WriteLine("grün");
                        break;
                    case 4:
                        Console.WriteLine("gelb");
                        break;
                    default:
                        Console.WriteLine($"{number} ist keine gültige Zahl");
                        break;
                }
            }
            
            //Schreibe Aufgabe 1 erneut. Benutze jedoch diesmal den conditional operator "?"

            Console.WriteLine("What is your first number?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            var num2 = int.Parse(Console.ReadLine());
            var text = num1 == num2 ? "die zahlen sind gleich" : "die zahlen sind nicht gleich";
            Console.WriteLine(text);

        }
    }
}