using System;
using System.Collections.Generic;
using System.Text;

namespace oopUppgift1
{
    class Person
    {
        public string name;
        public int age;
        public int weight;
        public int birthYear;
        
        
        public Person(string aName, int aAge, int aWeight, int aBirthYear)
        {
            name = aName;
            age = aAge;
            weight = aWeight;
            birthYear = aBirthYear;
        }
        
        public bool IsAdult()
        {
            if (this.age > 18)
            {
                return true;
            }
            return false;
        }
        public void Introduce()
        {
            Console.WriteLine($"This is {name}, they are {age} years old, they weigh {weight}kg, they where born in {birthYear}.\n");
        }
    }
}
