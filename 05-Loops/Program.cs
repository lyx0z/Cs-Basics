namespace _5_Loops;
class Program
{
    static void Main(string[] args)
    {
        //Schreibe ein Programm, dass die Summe der Zahlen von 1 bis 10 berechnet und gib diese aus.
        //Ändere das Programm, dass nur die Summe der geraden Zahlen berechnet werden soll.
        var sum = 1;

        for (var count = 0; count <= 10; count++)
        {
            if (count % 2 == 0)
            {
             sum += count;
            }
        }
        Console.WriteLine(sum);
        
        for (var i = 0; i <= 10; i++)
        {
            if (i == 2) {
                break;
            }
            Console.WriteLine(i);
            //output 0, 1
        }
        
        for (var i = 0; i <= 10; i++) 
        {
            if (i == 2) {
                continue;
            }

            Console.WriteLine(i);
            //output 0, 1, 3, 4....
        }
        /*break wird das ganze loop aufhören und in main weiter code rennen lassen,
         beim continue wird eine iteration stoppen wann die keyword continue vorkommt, 
         und danach wird mit den nöchsten iteration in den loop weitermachen.*/
        
        //Schreibe ein Programm, dass eine Pyramide folgendermassen auf der Konsole ausgibt:

        Console.WriteLine("amout of layers");
        int.Parse(Console.ReadLine(), out var totalLayers);
        for (var currentLayer = 1; currentLayer <= totalLayers; currentLayer++)
        {
            for (var spaceAmount = totalLayers - currentLayer; spaceAmount > 0; spaceAmount--)
            {
                Console.Write(' ');
            }

            for (var starAmount = currentLayer; starAmount > 0; starAmount--)
            {
                Console.Write("* ");
            }
            Console.Write('\n');
        }
        
        /* Schreibe ein Quiz mit einem Thema deiner Wahl. Dabei sollen 4 Antworten existieren und nur eine davon richtig sein (Single Choice). So lange der Benutzer nicht die richtige Antwort gegeben hat,
        soll das Quiz wieder von vorne beginnnen. Wenn die richtige Antwort gegeben wird, soll das Program beendet werden. Benutze dafür einen while-loop.*/

        
        var correctAnswer = "yellow";
        Console.WriteLine("What colors are bananas?: ");
        Console.WriteLine("red/orange/blue/yellow");
        var userAnswer = Console.ReadLine();
        while (userAnswer != correctAnswer)
        {
            Console.WriteLine("WRONG!");
            Console.WriteLine("red/orange/blue/yellow");
            userAnswer = Console.ReadLine();
            
        }
        Console.WriteLine("CORRECT!");
    }
}