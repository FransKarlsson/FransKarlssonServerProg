using System;

namespace extraUppgifter
{

    class Program
    {
        // Skriver ut inehållet i en array, overloadad för att kunna hantera string arrays.
        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ ", ");
            }
            Console.WriteLine();
        }
        static void WriteArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        // Aderar alla element i en array
        static int sumArray(int[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i++)
            {
                total += i;
            }

            return total;
        }
        // Skriver ut en arrays inehåll baklänges
        static void WriteArrayReverse(int[] array)
        {
            for (int i = array.Length-1; i >= 0; i-=1)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Upg 1
            Console.WriteLine("Upg 1:");
            WriteArray(numbers);

            // Upg 2
            Console.WriteLine("Upg 2:");
            WriteArrayReverse(numbers);

            // Upg 3
            Console.WriteLine("Upg 3:");
            Console.WriteLine(sumArray(numbers));

            // Upg 4
            Console.WriteLine("Upg 4:");
            int[] numbers2;
            numbers2 = numbers;
            WriteArray(numbers);
            WriteArray(numbers2);

            Console.WriteLine("Done");

            
        }
        
    }
}
