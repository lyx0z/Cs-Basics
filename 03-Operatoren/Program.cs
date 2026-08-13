namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreibe ein Programm, dass zuerst eine Zahl mit sich selbst addiert und dann mit 5 multipliziert und speichere das Ergebnis in einer neuen Variable.
            Console.WriteLine("Enter your number: ");
            var number = 1;
            Int32.TryParse(Console.ReadLine(), out number);
            var number2 = (number + number) * 5;
            Console.WriteLine(number2);
            
            //Schreibe ein Programm, welches zwei Integer als Input erwartet und dann ausgibt, wie viel Rest bei einer Teilung übrigbleibt, also z.B. 10 / 3 → Rest 1.
            Console.WriteLine("Enter your first number: ");
            var firstNumber = 0;
            Int32.TryParse(Console.ReadLine(), out firstNumber);
            Console.WriteLine("Enter your first number: ");
            var secondNumber = 0;
            Int32.TryParse(Console.ReadLine(), out secondNumber);
            var result = firstNumber % secondNumber;
            Console.WriteLine(result);
            
            //Was ist das Ergebnis der beiden Beispielen und wieso unterscheiden sich diese?
            var a1 = 3 + 2 * 5;
            var b2 = (3 + 2) * 5;
            Console.WriteLine(a1);
            Console.WriteLine(b2);
            //wegen punkt vor strich regeln die noch in c# gelten
            
            //Was ist das Ergebnis von diesen Beispielen und wieso? (Probiers zuerst auf dem Papier )
            var a = true && false || true;
            // true
            var b = (true || false ) && (false && true);
            //false
            var c = !true || false; 
            //false
            var d = !(true || false); 
            //false
            var e = true ^ true;
            //false
            var f = false ^ true;
            //true


        }
    }
}

