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
            
            
            //Schreibe eine Methode, die jedes Element eines Arrays mit Ganzzahlen mit sich selbst multipliziert und als Array in der gleichen Reihenfolge zurückgibt. Benutze dafür foreach.
            static int[] ArrayMultiplication(int[] arr)
            {
                var multiplicated = new int[arr.Length];
                var index = 0; 

                foreach (var number in arr)
                {
                    multiplicated[index] = number * number;
                    index++;
                }

                return multiplicated;
            }

            int[] numbers = [1, 2, 3, 4, 5];
            var multiplicated = ArrayMultiplication(numbers);

            foreach (var number in multiplicated)
            {
                Console.WriteLine(number);
            }
            //Schreibe eine eigene Sortiermethode (also nicht Sort() benutzen) für einen Ganzzahligen-Array.
            static int[] ArraySort(int[] arr)
            {
                var sorted = new int[arr.Length];
                int temp = 0;
                for (int i = 0; i <= arr.Length-1; i++)  
                {  
                    for (int j = i+1; j < arr.Length; j++)  
                    {  
                        if (arr[i] > arr[j])  
                        {  
                            temp = arr[i];  
                            arr[i] = arr[j];  
                            arr[j] = temp;  
                        }  
                    }  
                }

                return arr;
            }
            int[] arrayToSort = [5, 4, 3, 2, 1, 7, 8, 6, 9];
            var sorted = ArraySort(arrayToSort);
            foreach (var item in sorted)  
            {  
                Console.WriteLine(item);  
            }  
            
            //Schreibe eine Methode, mit der du einem Array von Ganzzahlen ein Element hinzufügen kannst.
            
            
        }
    }
}