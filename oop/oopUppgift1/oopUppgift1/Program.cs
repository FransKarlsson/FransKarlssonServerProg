using System;
using System.Collections.Generic;
namespace oopUppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> Personer = new List<Person>();
           

            //Elvever
            Personer.Add(new Person("Axel Jobson", 18, 70, 2003));
            Personer.Add(new Person("Axel Jörnulf", 19, 110, 2002));
            Personer.Add(new Person("Axel Lindblad", 18, 67, 2003));
            Personer.Add(new Person("Frans Karlsson", 18, 60, 2003));
            Personer.Add(new Person("Axel Sturesson", 18, 75, 2003));
            Personer.Add(new Person("Adam Al-Badre", 18, 70, 2003));
            Personer.Add(new Person("Arvid Andersson", 18, 70, 2003));
            Personer.Add(new Person("Oliver Bergström", 18, 70, 2003));
            Personer.Add(new Person("Oliver Davcev Talcoth", 18, 70, 2003));
            
            foreach (var Person in Personer)
            {
                Person.Introduce();
                Console.WriteLine(Person.IsAdult());
            }

            List<Kurs> Kurser = new List<Kurs>();
            // Kurser
            Kurser.Add(new Kurs("Fysik2", "FYSFYS02", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Matte4", "MATMAT04", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Kemi1", "KEMKEM01", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Programmering", "PRRPRR02", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Svenska", "SVESVE03", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Webbserver", "WESWEB01", "27/08/2021", "03/06/2022"));
            Kurser.Add(new Kurs("Webbutveckling", "WEUWEB01", "27/08/2021", "03/06/2022"));
           
            foreach (var Kurs in Kurser)
            {
                Kurs.Description();
            }

            


            


        }
    }
}
