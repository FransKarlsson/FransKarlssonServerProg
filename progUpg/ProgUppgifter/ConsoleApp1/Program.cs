using System;

namespace ConsoleApp1
{
    class Program
    {
        static void complementAge(string age)
        {
           
            Console.WriteLine("Du ser yngre ut än "+ age);
        }
        static string getStringInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }

        static int getIntInput(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        static int division(int num1, int num2)
        {
            return num1 / num2;
        }

        static int subtraktion(int num1, int num2)
        {
            return num1 - num2;
        }

        static int multiplikation(int num1, int num2)
        {
            return num1 * num2;
        }

        static int multiplikationThreeTimes(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void printMultiplicationTable(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i*num);
            }
        }

        static void switchInt(int num1, int num2)
        {
            int holder;
            holder = num1;
            num1 = num2;
            num2 = holder;
            Console.Write(num1);
            Console.WriteLine(num2);
        }

        static double avarageFromFour(double num1, double num2, double num3, double num4)
        {
            double total = num1 + num2 + num3 + num4;
            return total / 4;
        }

        static bool onePosetiveOneNegative(int num1, int num2)
        {
            if (num1 >= 0 && num2 < 0)
            {
                return true;
            }
            else if (num1 < 0 && num2 >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        static int sumAllNaturalNumbersTo(int max)
        {
            int j = 0;
            for (int i = 0; i <= max; i++)
            {
                j += i;
            }
            return j;

        }

        static int differance(int num1, int num2)
        {
            int differance = Math.Abs(num1 - num2);
            if (num1 > num2) 
            {
                differance *= 2;
            }
            return differance;
        }

        static bool testFor20(int num1, int num2)
        {
            if (num1 == 20 || num2 == 20 || num1 + num1 == 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int numTrippleIfSame(int num1, int num2)
        {
            int ans = 0;
            ans = num1 + num2;
            if (num1 == num2)
            {
                ans *= 3;
            }
            return ans;
        }

        static int differanceTo51(int n)
        {
            int dif = Math.Abs(n - 51);
            if (n > 51)
            {
                dif *= 3;
            }
            return dif;
        }

        static bool testFor30(int num1, int num2)
        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            // Upg 1
            Console.WriteLine("Hej\nFrans");


            // Upg 2
            Console.WriteLine(addition(3,5));


            //upg 3
            Console.WriteLine(division(9,3));


            // Upg 4
            switchInt(60, 5);

            // Upg 5
            multiplikationThreeTimes(getIntInput("Skriv in tal 1"), getIntInput("Skriv in tal 2"), getIntInput("Skriv in tal 3"));

            // Upg 6
            string operation = getStringInput("Välj en operation (+ - * /)");
            switch(operation)
            {
                case "+":
                    addition(getIntInput("Skriv tal 1"), getIntInput("Skriv tal 2"));
                    break;
                case "-":
                    subtraktion(getIntInput("Skriv tal 1"), getIntInput("Skriv tal 2"));
                    break;
                case "*":
                    multiplikation(getIntInput("Skriv tal 1"), getIntInput("Skriv tal 2"));
                    break;
                case "/":
                    division(getIntInput("Skriv tal 1"), getIntInput("Skriv tal 2"));
                    break;
                default:
                    Console.WriteLine("Felaktig operation");
                    break;
            }

            // Upg 7
            printMultiplicationTable(4);

            // Upg 8
            Console.WriteLine(avarageFromFour(4.4, 10, 0, 55));

            // Upg 9
            complementAge(getStringInput("Hur gammal är du?"));

            // Upg 10
            Console.WriteLine(onePosetiveOneNegative(2, 6));
            Console.WriteLine(onePosetiveOneNegative(-4, -10));

            // Upg 11
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            // Upg 12
            Console.WriteLine(sumAllNaturalNumbersTo(10));

            // Upg 13
            differance(10, 7);

            // Upg 14
            testFor20(7, 13);

            // Upg 15
            numTrippleIfSame(5, 6);

            // Upg 16
            differanceTo51(88);

            // Upg 17
            testFor30(5, 25);

        }
    }
}
