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
                Console.Write(array[i] + ", ");
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
                total += array[i];
            }

            return total;
        }
        // Skriver ut en arrays inehåll baklänges
        static void WriteArrayReverse(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i -= 1)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        static bool sex()
        {
            return false;
        }


        //Loopar igenom arrayen för varje element i arrayen för att pröva alla kombinationer.
        static int CountDuplicates(int[] array)
        {
            int duplicates = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j])
                    {

                        if (i == j)
                        {
                            continue;
                        }
                        duplicates++;
                    }
                }
            }
            return duplicates / 2;
        }

        //Loopar igenom arrayen för varje element i arrayen för att pröva alla kombinationer.
        static int[] LookForSums(int sum, int[] arr)
        {
            int[] answer = { 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    //Console.WriteLine($"i{arr[i]}  j{arr[j]}");

                    if (arr[i] + arr[j] == sum)
                    {
                        answer = new int[] { arr[i], arr[j] };

                    }

                }
            }
            return answer;
        }

        static int[] RandomArray(int len, int minValue, int maxValue)
        {
            int[] array = new int[len];
            Random rnd = new Random();
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rnd.Next(minValue, maxValue + 1);
            }
            return array;
        }

       
        static int FindSumOfBiggestPart()
        {
            int[] numbers = { -2, 1, -3, 5, -1, 2, 1,-5, 4 };
            int maxSum = numbers[0];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                Console.Write(numbers[i]+" ");
                if (numbers[i] > sum)
                {
                    sum = numbers[i];

                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
                return maxSum;
        }

        static void Main(string[] args)
        {
            // upg 1
            int[] numbers = {10,1,7,3,2,9,4,1,11,11};
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
            WriteArray(numbers2);

            // Upg 5
            Console.WriteLine("Upg 5:");
            Console.WriteLine("Antalet dubletter är " + CountDuplicates(numbers));

            // Upg bonus

            int[] x = { 1, 1, 1 };
            Console.WriteLine(x.Length);

            Console.WriteLine("Bonus upg");
            WriteArray(LookForSums(20, numbers));

            

            // Upg bonus bonus

            int[] pee = RandomArray(10,-10,10);
            WriteArray(pee);

            int[] what;

            int[] numbers3 = { -2, 7, -10, 3, -1, 3, -9, 1, 0, 0};

            Console.WriteLine("Done");

            /*
             ha en start pung och en slut pungt i en array
            flytta slutpingten från första delan av arrayen till första och addera allt mellan, om summan är större än den förra hagsta summan så blir maxsumman den nya
            flytta startpungten frammåt ett steg och gör samma sak igen. osv
            
            
             */
            Console.WriteLine(FindSumOfBiggestPart());
        }
        
    }
}
