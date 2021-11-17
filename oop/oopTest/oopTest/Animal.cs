using System;
using System.Collections.Generic;
using System.Text;

namespace oopTest
{
    class Animal
    {
        
        public int legs;
        public int age;
        public string sound;
        public string color;
        private string isAnimal;
       public string IsAnimal
        {
            get { return isAnimal; }
            set { isAnimal = "yes"; }
        }
        public void MakeSound()
        {
            Console.WriteLine(sound);
        }

        


    }
}
