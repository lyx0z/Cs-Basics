using System.Diagnostics.CodeAnalysis;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schreibe eine Methode, die alle Elemente in einem Array zusammenzählt und diese als Summe zurückgibt und rufe diese mit geeigneten Beispielen auf.

            static void ArrSum()
            {
                int[] classAges = [16, 15, 21, 19];
                var sum = 0;
                
                for (int i = 0; i < classAges.Length; i++)
                {
                    sum = sum + classAges[i];
                }

                var ageAverage = sum / classAges.Length;
                Console.WriteLine(ageAverage);
            }
            ArrSum();
            
            //Schreibe eine Methode, die einen beliebigen Array entgegennimmt und diesen in der umgekehrten Reihenfolge wieder zurückgibt.

            static int[] ReverseArray(int[] array)
            {
                var reversed = new int[array.Length]; 
                var reversedIndex = 0;
                for (var i = array.Length - 1; i >= 0; i--)
                {
                    reversed[reversedIndex] = array[i];
                    reversedIndex++;
                }
                return reversed;
            }

            int[] nums = [1, 2, 3];
            var reversed = ReverseArray(nums);
            Console.WriteLine(reversed);

            foreach (var num in reversed)
            {
                Console.WriteLine(num);
            }
            
            



        }
    }
}