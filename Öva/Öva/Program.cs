using System;
using System.Linq;
using System.Collections.Generic;

namespace Öva
{
 

    class Program

    {
        
        static bool isAdmin(string name)
        {
            if(name == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double Addering(double tal1, double tal2)
        {
            return tal1 + tal2;
        }
        static double Subtraktion(double tal1, double tal2)
        {
            return tal1 - tal2;
        }
        static double Multiplikation(double tal1, double tal2)
        {
            return tal1 * tal2;
        }
        static double Division(double tal1, double tal2)
        {
            return tal1 / tal2;
        }


        static void sackiwacki()
        {
            Console.WriteLine("sackiwacki");
        }


        // Return to your roots
        static void print(string input)
        {
            Console.WriteLine(input);
        }
        static void print(float input)
        {
            Console.WriteLine(input);
        }
        static void print(bool input)
        {
            Console.WriteLine(input);
        }


        static void password()
        {
            Console.WriteLine("Enter the passward");
            string password = Console.ReadLine();
            if (password == "sacki")
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
        }


        static void Main(string[] args)
        {
            /*
             
            string name = "Frans";
            int age = 18;
            bool isCool = true;

            if (isCool)
            {
                Console.WriteLine("B-)");
            }

            Console.WriteLine("Hello mr " + name);

            password();

            for (int i = 0; i < 10000; i++)
            {
                age++;
            }
            Console.WriteLine(age);
            

            int x = 10;
            double x2 = x;

            double y = 50.40;
            int y2 = (int) y;
            Console.WriteLine(y);
            Console.WriteLine(x);

            double mynum = 24.567;
            int mynumnum =(int) mynum;
            double munumnumnum = mynumnum;

            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num+ " is your number");
            

            string car = "volvo";
            foreach (char i in car)
            {
                Console.WriteLine(i);
            }
            

            Console.WriteLine("Hur gammal är du");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Du har rätt till körkort");
            }
            else
            {
                Console.WriteLine("Du har inte rätt till körkort");
            }
            

            Console.WriteLine("Vem är du");
            string namn = Console.ReadLine();
            switch(namn)
            {
                case "Frans":
                    Console.WriteLine("Välkommen tillbaka");
                    break;

                case "what":
                    Console.WriteLine("What");
                    break;

                default:
                    
                    Console.WriteLine("Go away");
                    break;
            

            //välkomnar och frågar kunden
            Console.WriteLine("Välkommen till resturang snåp!");
            Console.WriteLine("\nSkriv det du vill välja: \n1:körv \n2:mos \n3:sås");
            string val = Console.ReadLine();

            //cool centence mixing
            Console.Write("Du har valt ");
            switch(val)
            {
                case "1":
                    Console.WriteLine("körv");
                    break;
                case "2":
                    Console.WriteLine("mos");
                    break;
                case "3":
                    Console.WriteLine("sås");
                    break;
                default:
                    Console.WriteLine("fel");
                    break;
            }
            

            string[] cars = { "volvo", "ford", "what", "penis", "cor", "engine", "peugot", "opel", "gurgli" };
            int i = 0;
            while (i < cars.Length)
            {
                print(cars[i]);
                i++;
            }
            

            print("hello world");
            */




            ////Utan metod, loopar baklänges
            //List<string> djur = new List<string> { "dog", "horse", "duck", "pig" };
            //djur.Add("gubbon");
            //djur.Add("Pingin");

            //for (int i = djur.Count-1;  i>=0 ; i--)
            //{
            //    Console.WriteLine(djur[i]);
            //}

            //Console.WriteLine(" ");

            ////Använder metod, vänder listan och loopar som vanligt
            //djur.Reverse();
            //for (int i = 0; i < djur.Count; i++)
            //{
            //    Console.WriteLine(djur[i]);
            //}

            /*
            Console.WriteLine("Välkommen till miniräknare\nSkriv J om du bill börja");
            string start = Console.ReadLine();
            while (true) {
                if (start == "J")
                {
                    Console.WriteLine("Välj en operation\n + - * eller /");
                    string operation = Console.ReadLine();

                    Console.WriteLine("Skriv ditt första tal");
                    double tal1;
                    tal1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv ditt andra tal");
                    double tal2;
                    tal2 = double.Parse(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine(Addering(tal1, tal2));
                            break;
                        case "-":
                            Console.WriteLine(Subtraktion(tal1, tal2));
                            break;
                        case "*":
                            Console.WriteLine(Multiplikation(tal1, tal2));
                            break;
                        case "/":
                            Console.WriteLine(Division(tal1, tal2));
                            break;
                        default:
                            Console.WriteLine("Felaktig operation");
                            break;


                    }
                    Console.WriteLine("Vill du köra igen? (J/N)");
                    start = Console.ReadLine();
                    if (start == "N")
                    {
                        break;
                    }
                    
                }
                else
                {
                    break;
                }
                    
            }
            */

            Console.WriteLine("Vad heter du?");
            string userName = Console.ReadLine();
            Console.WriteLine(isAdmin(userName));

            Console.ReadKey();
            
        } 
        
    }
}
