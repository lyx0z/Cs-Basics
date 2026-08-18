namespace _07_Arrays
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Schreibe eine Methode, die alle Elemente in einem Array zusammenzählt und diese als Summe zurückgibt und rufe diese mit geeigneten Beispielen auf.
            ArrSum();
            //Schreibe eine Methode, die einen beliebigen Array entgegennimmt und diesen in der umgekehrten Reihenfolge wieder zurückgibt.
            int[] nums = [1, 2, 3];
            var reversed = ReverseArray(nums);
            Console.WriteLine(reversed);

            foreach (var num in reversed)
            {
                Console.WriteLine(num);
            }
            //Schreibe eine Methode, die jedes Element eines Arrays mit Ganzzahlen mit sich selbst multipliziert und als Array in der gleichen Reihenfolge zurückgibt. Benutze dafür foreach.
            int[] numbers = [1, 2, 3, 4, 5];
            var multiplied = ArrayMultiplication(numbers);
            
            foreach (var number in multiplied)
            {
                Console.WriteLine(number);
            }
            //Schreibe eine eigene Sortiermethode (also nicht Sort() benutzen) für einen Ganzzahligen-Array.
            //int[] arrayToSort = [5, 4, 3, 2, 1, 7, 8, 6, 9];
            var arrayToSort = Enumerable.Range(0, 100).Select(_ => Random.Shared.Next(0, 100)).ToArray();
            var sorted = ArraySort(arrayToSort);
            foreach (var item in sorted)  
            {  
                Console.WriteLine(item);  
            }  
            //Schreibe eine Methode, mit der du einem Array von Ganzzahlen ein Element hinzufügen kannst.
            int[] array = [1, 2, 3, 4, 5];
            var newArray = ArrayAddIndex(array);
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }

        private static void ArrSum()
        {
            int[] classAges = [16, 15, 21, 19];
            var sum = 0;
                
            for (var i = 0; i < classAges.Length; i++)
            {
                sum = sum + i;
            }

            var ageAverage = sum / classAges.Length;
            Console.WriteLine(ageAverage);
        }

        private static int[] ReverseArray(int[] array)
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

        private static int[] ArrayMultiplication(int[] arr)
        {
            var multiplied = new int[arr.Length];
            var index = 0; 

            foreach (var number in arr)
            {
                multiplied[index] = number * number;
                index++;
            }

            return multiplied;
        }

        private static int[] ArraySort(int[] arr)
        {
            var sorted = (int[])arr.Clone();
            var temp = 0;
            for (var i = 0; i <= sorted.Length-1; i++)  
            {  
                for (var j = i+1; j < sorted.Length; j++)  
                {  
                    if (sorted[i] > sorted[j])  
                    {  
                        temp = sorted[i];  
                        sorted[i] = sorted[j];  
                        sorted[j] = temp;
                    }  
                }  
            }

            return sorted;
        }

        private static int[] ArrayAddIndex(int[] arr)
        {
            Console.WriteLine("what number do you want to add?");
            var newIndex = int.Parse(Console.ReadLine());
            var newArray = new int[arr.Length + 1];
            arr.CopyTo(newArray, 0);
            newArray[arr.Length] = newIndex;
            return newArray;
        }
    }
}