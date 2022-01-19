using System;
using System.Linq;


namespace Assessment1
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            Random rand = new Random();
            
            int index = rand.Next(numbers.Length);
            var notSorted = numbers;
            Array.Sort(numbers);

            Console.WriteLine($"Randomly removed number in the array (sorted) is: {numbers[index]}");
            Console.WriteLine($"Randomly removed number in the array (not sorted) is: {notSorted[index]}");
            Console.ReadKey();

        }
    }
}