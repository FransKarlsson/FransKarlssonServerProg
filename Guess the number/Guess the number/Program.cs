using System;

namespace Guess_the_number
{
    class Program
    {
        static int GetIntInput(string msg)
        {
            while (true)
            { 
                try
                {
                    Console.Write(msg);
                    int output = Convert.ToInt32(Console.ReadLine());
                    return output;
                }
                catch
                {
                    Console.WriteLine("The input must be a number.");
                    
                }
            }
            
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 101);
            Console.WriteLine(answer);

            while (true)
            {
                
                int guess = GetIntInput("Enter your guess:");

                if (guess < answer)
                {
                    Console.WriteLine("Your answer is too low, try again:");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Your answer is too high, try again:");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    break;
                }
            }


            
        }
    }
}
